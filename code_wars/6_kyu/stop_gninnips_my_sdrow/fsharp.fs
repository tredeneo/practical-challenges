//no points
let spinWords (str: string) =
    str.Split " " // error " " -> ' '
    |> Seq.map (function
        | c when c |> String.length >= 5 -> c |> Seq.rev |> Seq.toArray |> System.String
        | c -> c)
    |> String.concat " "

let spinWordsTest name expected input =
    printfn "%A " ("", expected, spinWords input)

let spinWordsTestWithPrintInput expected input =
    spinWordsTest (sprintf "%A" input) expected input

let suite =
    [ [ "emocleW", "Welcome"
        "Hey wollef sroirraw", "Hey fellow warriors"
        "This is a test", "This is a test"
        "This is rehtona test", "This is another test"
        "You are tsomla to the last test", "You are almost to the last test"
        "Just gniddik ereht is llits one more", "Just kidding there is still one more" ]
      |> Seq.map (fun p -> p ||> spinWordsTestWithPrintInput) ]

printfn "%A" suite
