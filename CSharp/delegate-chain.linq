<Query Kind="Program" />

void Main()
{
	Action<string> func = null;
	func += str => str.Length.Dump();
	func += str => (str.Length * 2).Dump();
	func += str => (str.Length * 3).Dump();
	
	func.GetInvocationList().Dump();
	
	func("hoge");
}
