open System

let rec ReadList n = 
    if n = 0 then []
    else
        let Head = System.Convert.ToInt32(System.Console.ReadLine())
        let Tail = ReadList (n-1)
        Head::Tail

let rec WriteList = function
    | [] -> ()
    | head::tail -> 
        printfn "%O" head
        WriteList tail

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n
    printfn "Положительные элементы:"
    List.filter (fun x -> x >= 0) list |> WriteList
    printfn "Отрицательные элементы:"
    List.filter (fun x -> x < 0) list |> WriteList
    0
