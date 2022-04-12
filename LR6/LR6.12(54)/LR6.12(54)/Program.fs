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

let prov list element =
    let rec prov1 list elem count =
        match list with
        | [] -> count
        | h::t -> 
            let new_count = 
                if h = elem then count + 1 
                else count
            prov1 t elem new_count
    prov1 list element 0

let search list pred =
    let rec search1 list pred new_list =
        match list with
        | [] -> new_list
        | h::t ->
            let New_list = 
                if pred h then new_list @ [h] 
                else new_list
            search1 t pred New_list    
    search1 list pred []

let DeleteElements list el = 
    search list (fun x -> (x <> el))

let DeletePovtor list = 
    let rec DeletePovtor1 list listok = 
        match list with
            | [] -> listok
            | h::t -> 
                let tail = DeleteElements t h
                let new_list = listok @ [h]
                DeletePovtor1 tail new_list
    DeletePovtor1 list [] 

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = Console.ReadLine() |> Convert.ToInt32
    let list = ReadList n

    let BigThen3 = search list (fun x -> prov list x > 3)
    let Otvet = DeletePovtor BigThen3

    printfn "Элементы, которые встречаются более 3 раз:"
    writeList Otvet
    0