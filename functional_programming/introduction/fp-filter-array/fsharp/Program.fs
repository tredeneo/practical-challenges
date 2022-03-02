open System

let read _ =
    [
     let mutable key = Console.ReadLine()
     while not (key = null) do
        yield key
        key <-  Console.ReadLine()
    ]

//not worked
let read_alternative _ =
        let lista =
            Seq.initInfinite (fun _ -> Console.ReadLine())
            |> Seq.takeWhile (String.IsNullOrWhiteSpace >> not)
        lista

[<EntryPoint>]
let main args = 
    // let S = Console.ReadLine() |> int
    let S = 3
    // read()
    [1;2;3]
    |> List.filter (fun x -> x |> int < S)
    |> List.iter (printfn "%i")
    0

