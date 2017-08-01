<Query Kind="FSharpProgram" />

// ゼロ・奇数・偶数を識別するレコグナイザー関数
let (|Zero|Even|Odd|) value =
  match value, (value % 2) with
  | 0, _ -> Zero
  | _, 0 -> Even (value / 2) // 除算結果を返す
  | _, 1 -> Odd (value / 2)  // 除算結果を返す
 
let value = 131
 
match value with
// レコグナイザーを使って判定とキャプチャを行う
// ゼロにマッチ
| Zero ->
  System.Console.WriteLine("Zero")
 
// 偶数にマッチ
| Even half ->
  System.Console.WriteLine(
    System.String.Format(
      "Even: HalfValue={0}", half))
 
// 奇数にマッチ
| Odd half ->
  System.Console.WriteLine(
    System.String.Format(
      "Odd: HalfValue={0}", half))
 
// (Zero・Even・Odd以外の値にはなり得ない)