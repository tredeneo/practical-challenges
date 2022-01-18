open System
let entrada =
    let quantidade = Console.ReadLine() |> int
    ignore


let mostrar  x = 
    let char = Console.ReadLine()
    [0..x]|> List.iter (fun _ -> printfn "%s" char)
     

// For more information see https://aka.ms/fsharp-console-apps

[<EntryPoint>]
let main =
    let s = Console.ReadLine() |> int
    let list =
        [
         let mutable key = Console.ReadLine()
         while not (key = null) do
            yield key
            key <- Console.ReadLine()
            mostrar key
        ]
    0
