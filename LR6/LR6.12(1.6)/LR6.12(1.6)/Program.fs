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
    
let sdvig_l (list: 'a list) =
    if list.Length <= 1 then list
    else
        list.Tail @ [list.Head]

let rec sdvig_left list n = 
    if n = 0 then list
    else
        let new_n = n - 1
        let new_list = sdvig_l list
        sdvig_left new_list new_n


[<EntryPoint>]
let main argv = 
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    printfn "Новый список"
    let sdvig = sdvig_left list 3
    writeList sdvig
    0 
