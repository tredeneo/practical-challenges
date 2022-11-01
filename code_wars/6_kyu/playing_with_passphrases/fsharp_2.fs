open System

let playPass (s: string) (shift: int) : string =
    s.ToLower()
    |> Seq.mapi (fun index ->
        function
        | c when Char.IsNumber c -> (int '9' + int '0') - int c |> char
        | c when Char.IsLetter c ->
            let invert =
                function
                | r when index % 2 = 0 -> r |> Char.ToUpper
                | r -> r |> Char.ToLower

            let shift x =
                ((int x - int 'a' + shift) % 26) + int 'a' |> char

            c |> shift |> invert
        | c -> c)
    |> Seq.rev
    |> Seq.toArray
    |> String

