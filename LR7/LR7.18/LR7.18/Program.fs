open System

let ReadList n =
    let rec ReadList1 n arr = 
        if n = 0 then arr
        else
            let el = System.Convert.ToInt32(System.Console.ReadLine())
            let new_arr = Array.append arr [|el|]
            let new_n = n - 1
            ReadList1 new_n new_arr
    ReadList1 n Array.empty

let write_array arr =
    printfn "%A" arr

[<EntryPoint>]
let main argv =
   printfn "Сколько элементов в первом списке?"
   let n = System.Convert.ToInt32(System.Console.ReadLine())
   let list1 = ReadList n
   printfn "Сколько элементов во втором списке?"
   let n1 = System.Convert.ToInt32(System.Console.ReadLine())
   let list2 = ReadList n1

   let otvet = Array.filter (fun x -> not (Array.contains x list1)) list2 |> Array.append list1 |> Array.sort
   write_array otvet
   0
