<Query Kind="FSharpProgram" />

"4. Tuples" |> stdout.WriteLine

let x = (1, "Hello")
let a,b = x
x |>  printfn "%A"
a |>  stdout.WriteLine
b |>  stdout.WriteLine

let y = (x, (a, b))
y |>  printfn "%A"

let z = (x, y, a)
z |>  printfn "%A"

let ((a', b'), y', a'') = z
a' |>  stdout.WriteLine
b' |>  stdout.WriteLine
y' |>  printfn "%A"
a'' |>  stdout.WriteLine
