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


let testComplement original valor esperado =
    let tmp = playPass original valor

    if tmp = esperado then
        printfn "%A" tmp
    else
        printfn
            " original:%s 
            \r esperado:%s
            \r resultado:%s\n"
            original
            esperado
            tmp

testComplement "I LOVE YOU!!!" 1 "!!!vPz fWpM J"
testComplement "I LOVE YOU!!!" 0 "!!!uOy eVoL I"
testComplement "MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015" 2 "4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO"
