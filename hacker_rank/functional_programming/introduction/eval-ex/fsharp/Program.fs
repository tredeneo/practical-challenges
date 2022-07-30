open System

let read a =
    [ 1..a ]
    |> List.map (fun _ -> Console.ReadLine() |> float)

let rec factorial =
    function
    | 0 -> 1
    | n -> [ 1..n ] |> List.reduce (*)

let exp arr =
    let series arr =
        [ 0..9 ]
        |> List.sumBy (fun x -> Math.Pow(arr, float x) / (float (factorial x)))


    arr |> List.map (series)


Console.ReadLine()
|> int
|> read
|> exp
|> List.iter (printfn "%.4f")
