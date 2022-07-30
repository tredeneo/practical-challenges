open System

let a =
    List.iter (fun _ -> printfn "Hello World") [ 1 .. (int (Console.ReadLine())) ]

let b =
    [ 1 .. (Console.ReadLine() |> int) ]
    |> List.iter (fun _ -> printfn "hello world")


let rec printHello n =
    printfn "Hello World"

    match n with
    | 0
    | 1 -> 0
    | _ -> printHello (n - 1)

[<EntryPoint>]
let main args =
    let n = Console.ReadLine() |> int
    printHello n
