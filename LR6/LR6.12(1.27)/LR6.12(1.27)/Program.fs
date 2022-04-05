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

[<EntryPoint>]
let main argv = 
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    printfn "Новый список"
    let sdvig = sdvig_l list
    writeList sdvig
    0 
