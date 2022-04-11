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

let min_elem list =
    let rec mir list current_min =
        match list with
        | [] -> current_min
        | h::t ->
            let new_current_min = if h < current_min then h else current_min
            mir t new_current_min    
    mir list list.Head

let max_elem list =
    let rec mir list current_max =
        match list with
        | [] -> current_max
        | h::t ->
            let new_current_max = if h > current_max then h else current_max
            mir t new_current_max    
    mir list list.Head

let rec contains list elem =
    match list with
    | [] -> false
    | h :: t ->
        if h = elem then true
        else contains t elem

let miss list = 
    let MinElem = min_elem list
    let MaxElem = max_elem list
    let rec miss list new_list current =
        if current = MaxElem then new_list
        else
            let new_list = if contains list current then new_list else new_list @ [current]
            let new_current = current + 1
            miss list new_list new_current           
    miss list [] MinElem
        

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = Console.ReadLine() |> Convert.ToInt32
    let list = ReadList n
    
    let missing = miss list
    printfn "Пропущенные числа:"
    writeList missing
    0
