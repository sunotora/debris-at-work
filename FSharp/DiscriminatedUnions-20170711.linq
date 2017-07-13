<Query Kind="FSharpProgram" />

type Drink = ItemName of string * Brand
and Brand = Kirin | Asahi | Suntry | Sapporo

let a = ("kuroLabel", Sapporo)
let (b, c) = a

b.Dump()
"----------".Dump()
c.Dump()
"----------".Dump()

let favoriteBeer = ItemName("kuroLabel", Sapporo)
favoriteBeer.Dump();

"----------".Dump()
favoriteBeer
|> fun (ItemName (a, b)) -> printfn "%A" b
