open System

let rec RecUp x =
    match x with
    | 0 -> 1
    | x -> (x % 10) * RecUp (x / 10)

let rec MaxRecUp n = 
    if n < 10 then n 
    else 
        if MaxRecUp(n / 10) > n % 10 then MaxRecUp(n / 10)
        else n % 10

let rec MinRecUp n = 
    if n < 10 then n 
    else 
        if MinRecUp(n / 10) < n % 10 then MinRecUp(n / 10)
        else n % 10
 
let TailDown n =
    let rec TailDown2 n res = 
        if n = 0 then res
        else 
            let NextRes = res * (n % 10)
            let Nextn = n / 10
            TailDown2 Nextn NextRes
    TailDown2 n 1
 
let MaxTailDown n =
    let rec MaxTailDown1 n res = 
        match n with
        |0 -> res
        |_ -> if n % 10 > res then (MaxTailDown1 (n / 10) (n % 10))
              else MaxTailDown1 (n / 10) res
    MaxTailDown1 n 0
 
let MinTailDown n =
    let rec MinTailDown1 n res = 
        match n with
        |0 -> res
        |_ ->
            if n % 10 < res then (MinTailDown1 (n / 10) (n % 10))
            else MinTailDown1 (n / 10) res
    MinTailDown1 n 10
 
 
[<EntryPoint>]
let main argv =
    Console.WriteLine("Введите число:")
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Рекурсия вверх: ", RecUp x)
    Console.WriteLine("Максимум: ", MaxRecUp x)
    Console.WriteLine("Минимум: ", MinRecUp x)
    Console.WriteLine("Хвостовая рекурсия: ", TailDown x)
    Console.WriteLine("Максимум: ", MaxTailDown x)
    Console.WriteLine("Минимум: ", MinTailDown x)
    0 
