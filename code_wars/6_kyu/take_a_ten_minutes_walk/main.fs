let isValidWalk walk =
    let filtrar valor =
        walk
        |> List.filter (fun i -> i = valor)
        |> List.length

    let somar x y = filtrar x - filtrar y

    let x = somar 'n' 's'
    let y = somar 'w' 'e'
    printfn "%d %d %d" x y (List.length walk)

    if (x % 2 = 0) && (y = x) && (List.length walk) = 10 then
        true
    else
        false
