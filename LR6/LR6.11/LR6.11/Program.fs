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

let  kolvo list =
   let rec kolvo1 list res=
        match list with 
        | [] -> res
        | h::tail->
            let newres = res+1     
            kolvo1 tail newres
   kolvo1 list 0

let Dobav list = 
    if kolvo list % 3 = 0 then list 
    else 
        if kolvo list % 3 = 1 then list @ [1] @ [1]
        else list @ [1]

let sum f list=
    let rec sum f list newlist = 
        match list with 
        | []-> newlist
        |a::b::c::tail->
            let res = f a b c
            let Nextlist = newlist @ [res]
            sum f tail Nextlist
    sum f list []
                

[<EntryPoint>]
let main argv = 
    printfn "Сколько элементов в списке?"
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    let list = ReadList n
    writeList (sum (fun x y z -> x+y+z) (Dobav list)) 
    0 
