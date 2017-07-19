<Query Kind="FSharpProgram" />

"5. Lists, Arrays, Seqs : Generation" |> stdout.WriteLine

"Lists" |> stdout.WriteLine
let lsInit = List.init 3 (fun i -> i * 2)
lsInit |> stdout.WriteLine

let lsGen = [0; 2; 4]
lsGen |> stdout.WriteLine

let lsGen2 = [0..8]
lsGen2 |> stdout.WriteLine

let lsGen2' = [0..2..8]
lsGen2' |> stdout.WriteLine

let lsGen3 = [for i in 0..3 -> 0.5 * float i]
lsGen3 |> stdout.WriteLine

let lsGen3' = [for i in 0..3 -> printf "Adding %A" i; 0.5 * float i]
lsGen3' |> stdout.WriteLine

let leGen4 = -1 :: 1 :: []
leGen4 |> stdout.WriteLine

let inserted = -1 :: lsGen2'
inserted |> stdout.WriteLine

let concated = lsGen2 @ lsGen2'
concated |> stdout.WriteLine

"Arrays" |> stdout.WriteLine
let arrayInit = Array.init 3 (fun i -> i * 2)
arrayInit |> stdout.WriteLine

let arrayGen = [|0; 2; 4|]
arrayGen |> stdout.WriteLine

let arrayGen2 = [|0..8|]
arrayGen2 |> stdout.WriteLine

let arrayGen2' = [|0..2..8|]
arrayGen2' |> stdout.WriteLine

let arrayGen3 = [|for i in 0..3 -> 0.5 * float i|]
arrayGen3 |> stdout.WriteLine

let arrayGen3' = [|for i in 0..3 -> printf "Adding %A" i; 0.5 * float i|]
arrayGen3' |> stdout.WriteLine

"Seqs" |> stdout.WriteLine
let seqGen = seq {for i in 0..10 do yield i}
let seqGen2 = seq {for i in 0..10 do printf "Adding %d" i; yield i}
seqGen |> stdout.WriteLine
seqGen2 |> stdout.WriteLine