<Query Kind="Program" />

void Main()
{
	var numberList = new List<string>{ "1", "2", "3", "4"};
	var numberList2 = new List<string>{ "1", "2", "3", "4"};
	
	var characterList = new List<string>{ "a", "b", "c", "d", "e" };
	var emptyList = new List<string>{};
	
	numberList.Zip(characterList, (x, y) => new {x, y}).Dump();

	numberList.Zip(characterList, (x, y) => x == y).Any(x => false).Dump();

	numberList.Zip(numberList2, (x, y) => x == y).All(x => x).Dump();

    numberList.All(x => true).Dump();

}

// Define other methods and classes here
