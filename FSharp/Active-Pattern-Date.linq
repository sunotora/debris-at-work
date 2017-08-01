<Query Kind="FSharpProgram" />

let (|Date|) (dt: System.DateTime) =
  dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.DayOfWeek
 
let now = System.DateTime.Now
 
// DateTimeをマッチングする
match now with
// レコグナイザーを使ってタプルに分解する
| Date (yyyy, MM, dd, HH, mm, _, _) ->

System.Console.WriteLine(System.String.Format("yyyy:{0} MM:{1} dd:{2} HH:{3} mm:{4}", yyyy, MM, dd, HH, mm))