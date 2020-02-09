module Projections

(* E1: Simplest answer *)

let projectCount (xs : Event seq) : unit =
    let count = xs |> Seq.length
    printfn "Count: %d" count

(* E1: Approaching it as a fold *)

let evolveCount count (x : Event) =
    count + 1

let projectCountViaFold xs =
    let res = (0, xs) ||> Seq.fold evolveCount
    printfn "Count: %d" res

(* TODO: the rest! *)

let projection2 (xs : Event seq) : unit =
    // START HERE!
    ()

let run (xs : Event seq) =
    // While there are plenty ways to chain the sequence through each projection in a single pass
    // using Seq.cache to hold them in memory after the first pass works for the datasets this workshop presents
    // and lets each implementation work based on query comprehensions, Seq expressions and/or even simple iteration/looping
    let xs = Seq.cache xs

    // EXERCISE 1: Count the events
    xs |> projectCount
    xs |> projectCountViaFold

    // Other exercises can be slotted in here - in practice for a real system, you'd likely feed items one by one into each evolve function
    xs |> projection2
