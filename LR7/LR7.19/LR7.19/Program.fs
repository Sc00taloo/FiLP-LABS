open System

let Peremeshka s =
    let length = String.length s
    if length <= 3 then
        s
    else
        let rand = System.Random()
        let dlina = [1 .. length-2]
        let peremeshka = [0] @ (List.sortBy(fun _ -> rand.Next(1, length-2)) dlina) @ [length - 1]
        String.init length (fun index -> s.[peremeshka.[index]].ToString())

let NotFirstAndLast s =
    let digits = String.filter (fun elem -> Char.IsDigit elem) s
    let letters = String.filter (fun elem -> Char.IsLetter elem) s
    String.concat "" [digits; letters]

let choose = function
    | 1 -> Peremeshka
    | _ -> NotFirstAndLast

[<EntryPoint>]
let main argv =
   printfn "Введите строку:"
   let str = Console.ReadLine()
   printfn "Какую задачу решить?"
   printfn "1. Перемешать символы в слове, кроме первого и последнего?"
   printfn "2. Расположить все цифры в начале строки, а буквы в конце?"
   System.Convert.ToInt32(System.Console.ReadLine()) |> choose <| str |> printfn "Новый список: %s" 
   0
