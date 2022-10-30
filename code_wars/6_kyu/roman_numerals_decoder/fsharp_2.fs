let (|Split|_|) (p:string) (s:string) =
    //active patterns 
    if s.StartsWith(p) then
        Some(s.Substring(p.Length))
    else
        None

let rec FromRoman =
        function
        | Split "M" tail -> 1000+ FromRoman tail
        | Split "CD" tail -> 400+ FromRoman tail
        | Split "CM" tail -> 900+ FromRoman tail 
        | Split "C" tail -> 100 + FromRoman tail 
        | Split "D" tail -> 500 + FromRoman tail 
        | Split "XL" tail -> 40+ FromRoman tail
        | Split "XC" tail-> 90 + FromRoman tail
        | Split "X" tail -> 10 + FromRoman tail
        | Split "L" tail -> 50 + FromRoman tail
        | Split "IV" tail -> 4+ FromRoman tail
        | Split "IX" tail -> 9 + FromRoman tail
        | Split "I" tail -> 1 + FromRoman tail
        | Split "V" tail ->5+ FromRoman tail
        | _ -> 0

    

let Equal (nome, verdadeiro, resposta) =
    printfn "%A" (nome, verdadeiro = resposta)

Equal("FromRoman I", 1, FromRoman "I")
Equal("FromRoman II", 2, FromRoman "II")
Equal("FromRoman MCMXC", 1990, FromRoman "MCMXC")
Equal("FromRoman MDCLXVI", 1666, FromRoman "MDCLXVI")
