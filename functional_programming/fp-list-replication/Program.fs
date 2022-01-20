open System
let read _ =
    [
     let mutable key = Console.ReadLine()
     while not (key = null) do
        yield key
        key <- Console.ReadLine()
    ]

[<EntryPoint>]
let main args =
    let S = Console.ReadLine() |> int
    read ()
    |> List.iter (fun item ->  
        List.replicate S item 
        |> List.iter (fun x -> printfn "%s" x))
    0
