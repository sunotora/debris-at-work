<Query Kind="FSharpProgram" />

open Microsoft.FSharp.Core.OptimizedClosures
let dlg = FSharpFunc<int, int, int>.Adapt (fun x y -> x + y)
dlg.Invoke (1, 2) |> stdout.WriteLine
dlg.Invoke (2, 5) |> stdout.WriteLine
