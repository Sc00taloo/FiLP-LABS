open System

let rec ReadList n = 
    if n=0 then []
    else
        let Head = System.Convert.ToInt32(System.Console.ReadLine())
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
                let new_min = 
                    if h < current_min then h 
                    else current_min
                mir t new_min
    mir list list.Head

let search_min_before list =
    let min_elem = min_elem list
    let rec mir (list: 'a list) new_list =
        if list.Head = min_elem then new_list
        else
            let new_list = new_list @ [list.Head]
            let next_list = list.Tail
            mir next_list new_list
    mir list []


[<EntryPoint>]
let main argv = 
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    printfn "Список из элементов расположенных перед первым минимальным элементом."
    let search = search_min_before list
    writeList search
    0 

