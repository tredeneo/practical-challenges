open System

let read _ =
    [ let mutable key = Console.ReadLine()

      while not (key = null) do
          yield key
          key <- Console.ReadLine() ]

let integral f left right =
    let dx = 0.001
    Seq.sum [ for x in left..dx..right -> (f x) * dx ]

let polynomialExpr aSeq bSeq x =
    Seq.zip aSeq bSeq
    |> Seq.map (fun (a, b) -> a * (x ** b))
    |> Seq.sum

let rotate f x =
    let y = f x
    y * y * Math.PI

let area aSeq bSeq left right =
    integral (polynomialExpr aSeq bSeq) left right

let volume aSeq bSeq left right =
    integral (rotate <| polynomialExpr aSeq bSeq) left right

[<EntryPoint>]
let main args =
    let x =
        read ()
        |> List.map (fun (x: string) -> x.Split(" ") |> Seq.ofArray |> Seq.map (float))

    let left = Seq.head x.[2]
    let right = Seq.last x.[2]
    let aSeq = x.[0]
    let bSeq = x.[1]
    let primeiro = area aSeq bSeq left right
    let segundo = volume aSeq bSeq left right
    printfn "%f" primeiro
    printfn "%f" segundo



    0
