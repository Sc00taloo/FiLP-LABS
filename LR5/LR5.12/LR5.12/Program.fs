open System

[<EntryPoint>]
let main argv =
    //printfn "Какой язык проиграммирования у тебя любимый?"
    //printfn "Prolog - 1, F# - 2, C++ - 3, C# - 4, Pascal - 5, Python - 6"
    let test n =
        match n with 
        | "1" | "2" -> printfn "Ну ты и подлиза"
        | _ -> printfn "Такое себе"

    printfn "Какой язык проиграммирования у тебя любимый?"
    printfn "Prolog - 1, F# - 2, C++ - 3, C# - 4, Pascal - 5, Python - 6"
    (Console.ReadLine >> test >> Console.WriteLine)()

    printfn "Какой язык проиграммирования у тебя любимый?"
    printfn "Prolog - 1, F# - 2, C++ - 3, C# - 4, Pascal - 5, Python - 6"
    let karr (x:string->unit) y = x(y())
    karr test Console.ReadLine
    0
