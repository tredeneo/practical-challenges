// no points
let inArray (a1: string list) (a2: string list) =
    a1
    |> List.filter (fun x -> a2 |> List.exists (fun y -> y.Contains(x)))
    |> List.distinct
    |> List.sort


let testInArray a1 a2 expectedOutput =
    printfn "%A" ("", expectedOutput, inArray a1 a2)

testInArray
    [ "arp"; "live"; "strong" ]
    [ "lively"
      "alive"
      "harp"
      "sharp"
      "armstrong" ]
    [ "arp"; "live"; "strong" ]

testInArray
    [ "xyz"; "live"; "strong" ]
    [ "lively"
      "alive"
      "harp"
      "sharp"
      "armstrong" ]
    [ "live"; "strong" ]

testInArray
    [ "live"; "strong"; "arp" ]
    [ "lively"
      "alive"
      "harp"
      "sharp"
      "armstrong" ]
    [ "arp"; "live"; "strong" ]

testInArray
    [ "live"
      "strong"
      "lyal"
      "lysh"
      "arp" ]
    [ "lively"
      "alive"
      "harp"
      "sharp"
      "armstrong" ]
    [ "arp"; "live"; "strong" ]
