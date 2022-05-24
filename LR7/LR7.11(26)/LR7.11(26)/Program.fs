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

let between list = 
    let minEl = List.min list
    let min1 = List.findIndex (fun (ind, a) -> a = minEl) (List.indexed list)
    // let min2 = List.findIndex(fun (ind, a) -> ind <> min1 && a = minEl) (List.indexed list)
    let min2 = List.findIndexBack(fun (ind, a) -> a = minEl) (List.indexed list)
    min2 - min1 - 1

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    let kol_el = between list
    if kol_el = -1 then printfn "Ошибка!"
    else
        Console.WriteLine($"Количесвто элеметво: {kol_el}")
    0