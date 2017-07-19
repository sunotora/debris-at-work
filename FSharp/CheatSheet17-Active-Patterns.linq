<Query Kind="FSharpProgram" />

"17. Active Patterns" |> stdout.WriteLine

// Basic
let (|Odd|) num = num % 2 = 0
let getEvenOdd x =
  match x with
  | Odd(odd) -> odd
  
let odd = getEvenOdd 1
odd.Dump()
let even = getEvenOdd 2
even.Dump()

// Multiple Patterns
let (|Odd|Even|) num =
  if num % 2 = 0 then Even(num)
  else Odd(num)

// とりあえずうごく
//let getEvenOdd' = function
//  | Odd(num) -> "Odd :" + num.ToString()
//  | Even(num) -> "Even:" + num.ToString()

// これは多分全く意味ないことしている
let getEvenOdd' = function
  | Odd(num) -> (|Odd|Even|) num
  | Even(num) -> (|Odd|Even|) num

let odd' = getEvenOdd' 1
odd'.Dump()
let even' = getEvenOdd' 2
even'.Dump()

// 意味ないことの途中経過
let printEvenOdd num =
  match getEvenOdd' num with
  | Choice1Of2 num -> "Odd:" + num.ToString()
  | Choice2Of2 num -> "Even:" + num.ToString()
  |> stdout.WriteLine

printEvenOdd 5
printEvenOdd 6
printEvenOdd 7

// たぶんこれが最終形
let printEvenOdd' = function
  | Odd(num) -> "Odd:" + num.ToString()
  | Even(num) -> "Even:" + num.ToString()

printEvenOdd' 5 |> stdout.WriteLine
printEvenOdd' 6 |> stdout.WriteLine
printEvenOdd' 7 |> stdout.WriteLine

// Partial Pattern
let (|Odd|_|) num =
  if num % 2 = 0 then None
  else Some(num)

let getOdd num =
  match num with
  | Odd(num) -> "Odd :" + num.ToString()
  | _ -> "Not Odd"

let odd'' = getOdd 1
odd''.Dump()
let even'' = getOdd 2
even''.Dump()

