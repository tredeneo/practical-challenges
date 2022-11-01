let (|Split|_|) (p:string) (s:string) =
    //active patterns 
    if s.StartsWith(p) then
        Some(s.Substring(p.Length))
    else
        None
