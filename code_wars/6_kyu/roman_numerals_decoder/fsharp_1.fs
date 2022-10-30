let rec FromRoman (romanNumeral: string) =
    let numerals = romanNumeral |> Seq.toList
    let send_recursive = 
        List.toArray >>  System.String >> FromRoman

    match numerals with 
    | [] -> 0
    | 'M' :: tail -> 1000 + send_recursive tail
    | 'C'::'D'::tail -> 400 + send_recursive tail
    | 'C' :: 'M' :: tail -> 900 + send_recursive tail
    | 'C' :: tail -> 100 + send_recursive tail
    | 'D':: tail -> 500 + send_recursive tail
    | 'X' :: 'L':: tail -> 40 + send_recursive tail
    | 'X' :: 'C' :: tail-> 90 + send_recursive tail
    | 'X' :: tail -> 10 + send_recursive tail
    | 'L' :: tail -> 50 + send_recursive tail
    | 'I':: 'V':: tail -> 4+ send_recursive tail
    | 'I':: 'X'::tail -> 9 + send_recursive tail
    | 'I' :: tail -> 1 + send_recursive tail
    | 'V'::tail ->5+ send_recursive tail




    

let Equal (nome, verdadeiro, resposta) =
    printfn "%A" (nome, verdadeiro = resposta)

Equal("FromRoman I", 1, FromRoman "I")
Equal("FromRoman II", 2, FromRoman "II")
Equal("FromRoman MCMXC", 1990, FromRoman "MCMXC")
Equal("FromRoman MDCLXVI", 1666, FromRoman "MDCLXVI")
