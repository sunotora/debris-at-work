<Query Kind="FSharpProgram" />

"3. Numbers" |> stdout.WriteLine
let int16Num = 10s
let int32Num = 20
let int64Num = 30L
let float32Num = 10.0f
let floatNum = 10.0
let int64From32 = int64 int32Num
// other conversion functions
// float float32 int int16

int16Num |> stdout.WriteLine
int32Num |> stdout.WriteLine
int64Num |> stdout.WriteLine
float32Num |> stdout.WriteLine
floatNum |> stdout.WriteLine
int64From32 |> stdout.WriteLine
