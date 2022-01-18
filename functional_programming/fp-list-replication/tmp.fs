List.iter (printfn "%s") (List.collect (fun x -> List.replicate num x) list)
