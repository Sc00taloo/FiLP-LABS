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

let LeftOn3 list n =
   let length = List.length list
   let LetOn3_ind ind = if ind < length - n then ind + n 
                           else if ind - (length - n) < length then ind - (length - n) 
                           else 0
   List.init (List.length list) (fun ind -> List.item (LetOn3_ind ind) list)

[<EntryPoint>]
let main argv =
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n

    let new_list = LeftOn3 list 3
    printfn "Новый список"
    WriteList new_list
    0