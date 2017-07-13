<Query Kind="Program" />

void Main()
{
	var hoge = new Dictionary<string, object> { {"key", "value"}, {"key2", "value2"} };
	var piyo = new Dictionary<string, object> { {"key", "value"}, {"key2", "value2"} };
    hoge.Equals(piyo).Dump();
	(hoge == piyo).Dump();
	hoge.SequenceEqual(piyo).Dump();

    var foo = DateTime.MinValue;
	var bar = DateTime.MinValue;
	(foo == bar).Dump();
}

// Define other methods and classes here
