module Program

[<EntryPoint>]
let main argv =
    match argv with
    | [| filePath |] ->
        let events = StreamReader.read<Event> filePath
        try Projections.run events; 0
        with e -> eprintfn "Exception: %O" e; 1
    | _ -> eprintfn "Please specify a file to replay"; 1