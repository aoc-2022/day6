open System.IO

let lines = File.ReadAllLines "/tmp/aoc/input" |> Array.toList |> List.map (fun s -> s.ToCharArray() |> Array.toList)

lines |> List.map (printfn "%A")  // findIndex(Back)=indexOfFirst, collect=flatMap, fold*

let rec skipToMarker (str: char list) =
    let s = str |> List.take 14 |> Set.ofList
    if s |> Set.count = 14 then 14
    else 1 + (str.Tail |> skipToMarker)
    
let skipped = lines |> List.map skipToMarker

skipped |> List.map (printfn "%A")


