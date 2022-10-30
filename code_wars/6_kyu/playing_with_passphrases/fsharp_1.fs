

open System
let playPass (s: string) (shift: int) : string = (* your code here! *)

    let reverse (xs:string)=
        xs.ToCharArray() |> Array.rev |> String

    let str = s.ToLower()
    str
    |> String.mapi(fun index rune -> 
        if Char.IsNumber(rune) then 
            let remain (x:int) = 
                9 - x 

            let tmp = rune 
                    |> string
                    |> int 
                    |> remain 
                    |> string
            tmp.Chars 0
                

        else if Char.IsLetter (rune) then
            let odd x =
                if x%2 = 0 then true
                else false
            let invert ch= 
                if odd index then
                    ch |> Char.ToUpper
                else
                    ch |> Char.ToLower
            let str =  string rune 
            let letter = (((Char.ConvertToUtf32 (str,0 ) - int('a')+ shift)%26)+int('a'))
            let tmp = Char.ConvertFromUtf32(letter).Chars 0
            tmp |> invert

        else rune
    ) 
    |> reverse


let testComplement original valor esperado = 
    let tmp = playPass original valor
    if tmp = esperado then 
        printfn "%A" tmp
    else
        printfn "%s\n%s\n%s" original esperado tmp

testComplement "I LOVE YOU!!!" 1 "!!!vPz fWpM J"
testComplement "I LOVE YOU!!!" 0 "!!!uOy eVoL I"
testComplement "MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015" 2 "4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO"
