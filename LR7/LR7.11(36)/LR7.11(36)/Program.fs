open System

let rec ReadList n = 
    if n = 0 then []
    else
        let Head = System.Convert.ToInt32(System.Console.ReadLine())
        let Tail = ReadList (n-1)
        Head::Tail

let max (list: int list) =
    let sorted = List.sortDescending list
    List.tryFind (fun x -> x % 2 = 1) sorted

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    let maxNum = max list

    if Option.isNone maxNum then printfn "Нет нечетных элементов"
    else
        printfn "Максимальный нечетный элемент: %d" (Option.get maxNum)
    0
