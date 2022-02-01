open System

let read _ =
    [ let mutable key = Console.ReadLine()

      while not (key = null) do
          yield key
          key <- Console.ReadLine() ]

let rec reverse =
    function
    | [] -> []
    | [ x ] -> [ x ]
    | head :: tail -> reverse tail @ [ head ]


read () |> reverse |> List.iter (printfn "%s")
