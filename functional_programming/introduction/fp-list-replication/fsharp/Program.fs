open System

let read _ =
    [ let mutable key = Console.ReadLine()

      while not (key = null) do
          yield key
          key <- Console.ReadLine() ]

let ver_1 lista S =
    lista
    |> List.iter (fun item ->
        List.replicate S item
        |> List.iter (fun x -> printfn "%s" x))


let ver_2 lista S =
    lista
    |> List.collect (List.replicate S)
    |> List.iter (printfn "%s")


[<EntryPoint>]
let main args =
    let S = Console.ReadLine() |> int
    (read (), S) ||> ver_2
    0
