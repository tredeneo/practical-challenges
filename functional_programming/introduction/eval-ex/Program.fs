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
        printfn "entrei"

        let a =
            [ 0..9 ]
            |> List.sumBy (fun x ->
                MathF.Pow(float32 arr, float32 x)
                / (float32 (factorial x)))

        printfn "passei"
        a

    arr |> List.map (series)


Console.ReadLine()
|> int
|> read
|> exp
|> List.iter (printfn "%.4f")
