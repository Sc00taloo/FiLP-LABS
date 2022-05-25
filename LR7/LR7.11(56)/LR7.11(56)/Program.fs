open System

let rec ReadList n = 
    if n = 0 then []
    else
        let Head = System.Convert.ToInt32(System.Console.ReadLine())
        let Tail = ReadList (n-1)
        Head::Tail

let simple x =
    let rec Simple x current =
        if current = 0 then false
        else if current = 1 then true
        else if x % current = 0 then false
            else
                let new_current = current - 1
                Simple x new_current
    Simple x (x - 1)

let get_sum_and_count pred list =
    List.fold (fun a x -> if pred (fst x) then (fst a + fst x, snd a + 1) else a) (0, 0) (List.zip list list)

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    let sumAndCount = get_sum_and_count (fun x -> simple x) list
    let sredSum = (double) (fst sumAndCount) / (double) (snd sumAndCount)

    let sumAndCountBig = get_sum_and_count (fun x -> not (simple x) && (double)x > sredSum) list
    let sredNotbig = (double) (fst sumAndCountBig ) / (double) (snd sumAndCountBig ) 

    printfn "Среднее простых: %f" sredSum
    printfn "Cреднее непростых элементов, больших, чем среднее простых: %f" sredNotbig

    0
