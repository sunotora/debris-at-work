<Query Kind="Program" />

void Main()
{
    var existsDir = $"C:\\temp\\hoge";
	var notExistsDir = $"C:\\temp\\hoge\\dummy\\dummy1";
    
	Directory.Exists(existsDir).Dump();
	
	Directory.CreateDirectory(notExistsDir);
	Directory.Exists(notExistsDir).Dump();
    
	var Dir = Path.GetDirectoryName("../../hoge");
	Directory.GetCurrentDirectory().Dump();
	Dir.Dump().ToString();

}

// Define other methods and classes here
