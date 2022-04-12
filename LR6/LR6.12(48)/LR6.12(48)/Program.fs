open System

let rec ReadList n = 
    if n=0 then []
    else
        let Head = Console.ReadLine() |> Convert.ToInt32
        let Tail = ReadList (n-1)
        Head::Tail

let rec writeList = function
    | [] -> ()
    | head::tail -> 
        printfn "%O" head
        writeList tail

let chastota list element =
    let rec chastota1 list elem count =
        match list with
        | [] -> count
        | h::t -> 
            let new_count = 
                if h = elem then count + 1 
                else count
            chastota1 t elem new_count
    chastota1 list element 0

let Cool_Elem list =
    let rec fiffif list elem current_max =
        match list with
        | [] -> elem
        | h::t -> 
            let fr_h = chastota list h
            let new_max = 
                if fr_h > current_max then fr_h 
                else current_max
            let new_elem = 
                if fr_h > current_max then h 
                else elem
            fiffif t new_elem new_max
    fiffif list 0 0

let index list elem =
    let rec fir list elem new_list idx =
        match list with
        | [] -> new_list
        | h::t ->
            let new_list = 
                if h = elem then new_list @ [idx] 
                else new_list
            let new_idx = idx + 1
            fir t elem new_list new_idx   
    fir list elem [] 0
        

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = Console.ReadLine() |> Convert.ToInt32
    let list = ReadList n
    
    let CoolElem = Cool_Elem list
    let CoolIndex = index list CoolElem

    printfn "Самый частый элемент: %d" CoolElem
    printfn "Индексы: "
    writeList CoolIndex
    0
