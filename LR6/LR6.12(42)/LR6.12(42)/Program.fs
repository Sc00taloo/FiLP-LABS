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

let rec contains list f acc = 
    match list with
    | [] -> acc
    | h::t ->
        let newAcc = f acc h
        contains t f newAcc

let list_sred list =
    let listSum = contains list (fun x y -> x + y) 0
    (double) listSum / (double) list.Length

let menishe_sred list pred =
    let rec countPred_r list pred new_list =
        match list with
        | [] -> new_list
        | h::t ->
            let new_new_list = if pred h then new_list @ [h] else new_list
            countPred_r t pred new_new_list
    
    countPred_r list pred []
        

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = Console.ReadLine() |> Convert.ToInt32
    let list = ReadList n
    
    let sred = list_sred list
    let MenisheSred = menishe_sred list (fun x -> (double) x < sred)

    printfn "Элементы, которые меньше, чем среднее число (%f):" sred
    writeList MenisheSred
    0
