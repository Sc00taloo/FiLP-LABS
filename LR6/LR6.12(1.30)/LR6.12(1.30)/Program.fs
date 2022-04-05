open System

let rec ReadList n = 
    if n=0 then []
    else
        let Head = System.Convert.ToInt32(System.Console.ReadLine())
        let Tail = ReadList (n-1)
        Head::Tail

let max_elem list =
    let rec mir list currect_max = 
        match list with
        | [] -> currect_max
        | h::t ->
            let new_currect_max = 
                if h > currect_max then h
                else currect_max
            mir t new_currect_max
    mir list list.Head

let global_max list x = 
    let min_value = max_elem list
    let rec check (list: 'a list) x currect_x =
        if currect_x = x then list.Head = min_value
        else
            let new_currect_x = currect_x + 1
            let new_list = list.Tail
            check new_list x new_currect_x
    check list x 0

[<EntryPoint>]
let main argv = 
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    printfn "Какой индекс?"
    let x = Console.ReadLine() |> Convert.ToInt32

    let result = global_max list x
    printfn "%b" result
    0 

