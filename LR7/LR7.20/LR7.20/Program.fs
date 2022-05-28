open System

let ReadList n =
   let rec ReadList1 n list =
       match n with
       | 0 -> list
       | _ ->
           let new_list = list @ [Console.ReadLine()]
           let new_n = n - 1
           ReadList1 new_n new_list
   ReadList1 n []

let rec WriteList = function
    | [] -> ()
    | head::tail -> 
        Console.WriteLine($"{head}")
        WriteList tail

let RemoveAt index list =
   let rec rem_at1 index list cur_index new_list =
       match list with
       | [] -> new_list
       | head::tail ->
           let new_new_list = new_list @ if cur_index <> index then [head] else []
           let new_index = cur_index + 1
           rem_at1 index tail new_index new_new_list
   rem_at1 index list 0 []
      
let MedValList list =
   list |> List.sort |> List.item ((List.length list) / 2)

//Отсортировать строки в порядке увеличения медианного значения выборки строк
//(прошлое медианное значение удаляется из выборки и производится поиск нового медианного значения)
let Mediana list =
    let rec Subtask6_1 list sorted =
        match list with
        | [] -> sorted
        | head::tail ->
            let med = MedValList list
            let new_sorted = sorted @ [med]
            let new_list = RemoveAt ((List.length list) / 2) list
            Subtask6_1 new_list new_sorted
    Subtask6_1 list []

//Совмещает 2 карты, значения дублирующихся ключей складывает
let MergeMaps map1 map2 =
    Map.fold (fun res_map key value ->
        match Map.tryFind key res_map with
        | Some v -> Map.add key (value + v) res_map
        | None -> Map.add key value res_map) map1 map2

//Для строки возвращает карту: (буква -> кол-во)
let MakeStrMap (s:string) = 
    let result = Map.empty

    let sanitized = s.Replace(" ", "").ToLower()
    let char_list = Seq.toList sanitized
    let occur_tuples = List.countBy id char_list // Создает список кортежей: (буква, кол-во)

    Map.ofList occur_tuples

//Для алфавита возвращает карту (буква -> кол-во)
let MakeAlphabetMap strings_list =
    let rec makeAlphabetMap1 str_list map =
        match str_list with
        | [] -> map
        | head::tail ->
            let str_map = MakeStrMap head
            let new_map = MergeMaps map str_map
            makeAlphabetMap1 tail new_map
    makeAlphabetMap1 strings_list Map.empty

//Для алфавита возвращает карту (буква -> частота)
let MakeAlphabetFreqMap list = 
    let total_length = List.fold (fun accum (str:string) -> accum + str.Replace(" ", "").Length) 0 list
    let map = MakeAlphabetMap list
    Map.map (fun k v -> (double) v / (double) total_length) map

//Вернуть самый частый символ в строке
let MostFreqSymbol str =
    let chars = Seq.toList str
    let str_map = MakeAlphabetMap [str]
    List.sortByDescending (fun ch -> str_map.[ch]) chars |> List.item 0
 
//Отсортировать строки в порядке увеличения разницы между частотой наиболее часто
//встречаемого символа в строке и частотой его появления в алфавите
let UvelichenieRaznizi list =
    let alphabetFreq = MakeAlphabetFreqMap list
    List.sortBy (fun str -> Math.Abs((MakeAlphabetFreqMap [str]).[MostFreqSymbol str] - alphabetFreq.[MostFreqSymbol str])) list

let choose = function
    | 1 -> Mediana
    | _ -> UvelichenieRaznizi

[<EntryPoint>]
let main argv =
    printfn "Введите кол-во строк:"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    printfn "Введите список строк:"
    let list = ReadList n

    printfn "Выберите способ сортировки:"
    printfn "1. В порядке увеличения медианного значения выборки строк?"
    printfn "2. В порядке увеличения разницы между частотой наиболее часто встречаемого символа в строке и частотой его появления в алфавите?"

    let method = System.Convert.ToInt32(System.Console.ReadLine())
    let sorted_list = list |> choose method

    printfn "Отсортированный список:"
    WriteList sorted_list
    0
