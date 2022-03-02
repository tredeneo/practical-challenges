open System

let read _ =
    [ let mutable key = Console.ReadLine()

      while not (key = null) do
          yield key
          key <- Console.ReadLine() ]

let rec recursive_count =
    function
    | head :: tail -> 1 + recursive_count tail
    | _ -> 0

read () |> recursive_count |> printf "%d"
