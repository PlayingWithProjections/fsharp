module Projections

let run (xs : Event seq) =
    // While there are plenty ways to chain the sequence through each projection in a single pass, this lets one express
    // the derivations as pipeline expressions
    let xs = Seq.cache xs

    let count = Seq.length xs
    printfn "Count: %d" count
