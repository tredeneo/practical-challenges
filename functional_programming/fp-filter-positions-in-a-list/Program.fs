open System

let read _ =
    [ let mutable key = Console.ReadLine()

      while not (key = null) do
          yield key
          key <- Console.ReadLine() 
    ]

// recursive version
let rec f =
    function
    | _ :: (x :: xs) -> x :: f xs
    | _ -> []

// For more information see https://aka.ms/fsharp-console-apps
let odd_positions list =
    list
    |> List.mapi (fun i x -> (i, x |> int))
    |> List.filter (fun (i, j) -> i % 2 = 1)

read ()
|> odd_positions
|> List.iter (fun  (i,x) -> printfn "%d" x)
