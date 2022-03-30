open System

let rec nod n m =
    if n = 0 || m = 0 then n + m 
    else
        let newn = 
            if n > m then n % m 
            else n
        let newm = 
            if n <= m then m % n 
            else m
        nod newn newm
    

let sum x =
    let rec sum1 x suma n =
        if n < 1 then suma
        else
            let newSUM = 
                if x % n = 0 then suma + n 
                else suma
            let newN = n - 1
            sum1 x newSUM newN
    sum1 x 0 x

let kolichestvo x =
    let rec kolichestvo1 x n =
        if x = 0 then n
        else
            let newN =
                if x % 10 < 3 then n + 1 
                else n
            let newX = x / 10
            kolichestvo1 newX newN
    kolichestvo1 x 0

let sumPROS x =
    let rec sum1 x n = 
        if x < 1 then n
        else
            let newSUM =  n + (x % 10)
            let newN = x / 10
            sum1 newN newSUM
    sum1 x 0

let mnogo x =
    let sumPROSTIH = sumPROS x  
    let rec numN x num n =
        if num <= 0 then n
        else
            let newN = 
                if (x % num <> 0) && (nod num x <> 1) && (nod num sumPROSTIH = 1) then n + 1 
                else n
            let newNUM = num - 1
            numN x newNUM newN
    numN x (x-1) 0

let foon = function
    | 1 -> sum
    | 2 -> kolichestvo
    | _ -> mnogo


[<EntryPoint>]
let main argv =
    printfn "Enter number fun and number"
    let opts = (Console.ReadLine() |> Int32.Parse, Console.ReadLine() |> Int32.Parse)
    let result = foon (fst opts) (snd opts)
    printfn "%A" result
    0 
