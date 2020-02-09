module Projections

let projectCount (xs : Event seq) : unit =
    let count = xs |> Seq.length
    printfn "Count: %d" count

let projection2 (xs : Event seq) : unit =
    // START HERE!

let run (xs : Event seq) =
    // While there are plenty ways to chain the sequence through each projection in a single pass
    // using Seq.cache to hold them in memory after the first pass works for the datasets this workshop presents
    // and lets each implementation work based on query comprehensions, Seq expressions and/or even simple iteration/looping
    let xs = Seq.cache xs

    xs |> projectCount
    xs |> projection2
