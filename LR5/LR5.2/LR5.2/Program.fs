open System

let rec readFloat() =
    match System.Double.TryParse(System.Console.ReadLine()) with
    | false, _ -> printfn "?"; readFloat()
    | _, x -> x

let a = readFloat();
let b = readFloat();
let c = readFloat();

let solve = fun (a,b,c) ->
    let D = b*b-4.0*a*c
    if D<0.0 then printf "No answer"
    let x1 = (-b+sqrt(D))/(2.0*a)
    let x2 = (-b-sqrt(D))/(2.0*a)
    printfn "x1= %f" x1
    printf "x2= %f" x2

let res = solve(a,b,c);