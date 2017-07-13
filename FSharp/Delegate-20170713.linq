<Query Kind="FSharpProgram" />

open System

let dlg1 = Func<_,_,_>( fun x y -> x + y )
let dlg2 = Func<_,_,_>( fun x y -> x - y )
let dlg3 = Func<_,_,_>( fun x y -> x * y )

([dlg1;dlg2;dlg3],[(1,2);(3,4);(5,6)])
||> List.map2 ( fun dlg param -> dlg.Invoke param )
|>  stdout.WriteLine

Func<_,_,_>.Combine( dlg1, dlg2, dlg3 ).GetInvocationList()
|> Array.map ( fun dlg -> dlg :?> Func<int,int,int> )
|> fun ary -> 
    ( ary , [|(1,2);(3,4);(5,6)|] ) ||> Array.map2 ( fun dlg param -> dlg.Invoke param ) 
|> printfn "%A"


Func<_,_,_>.Combine( dlg1, dlg2, dlg3 ).GetInvocationList()
|> Array.map ( fun dlg -> dlg.DynamicInvoke(1,2) )
|> printfn "%A"
// [|3; -1; 2|]