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
    let maxEl = List.max list
    let max1 = List.findIndex (fun (ind, a) -> a = maxEl) (List.indexed list)
    // let max2 = List.findIndex (fun (ind, a) -> ind <> max1 && a = maxEl) (List.indexed list)
    let max2 = List.tryFindIndex (fun (ind, a) -> ind <> max1 && a = maxEl) (List.indexed list)
    let betweenInd= List.filter (fun a-> fst a > max1 && fst a < Option.get max2) (List.indexed list)
    List.map (fun x -> snd x) betweenInd
    

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    let new_list = between list
    printfn "Новый список"
    WriteList new_list
    0
