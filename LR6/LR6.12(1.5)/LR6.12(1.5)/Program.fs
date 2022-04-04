open System

let rec ReadList n = 
    if n=0 then []
    else
        let Head = System.Convert.ToInt32(System.Console.ReadLine())
        let Tail = ReadList (n-1)
        Head::Tail

let min_elem list =
    let rec mir list currect_min = 
        match list with
        | [] -> currect_min
        | h::t ->
            let new_currect_min = 
                if h < currect_min then h
                else currect_min
            mir t new_currect_min
    mir list list.Head

let global_min list x = 
    let min_value = min_elem list
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

    let result = global_min list x
    printfn "%b" result
    0 
