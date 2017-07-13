<Query Kind="Program" />

void Main()
{
	var date1 = new DateTime(1970, 1, 1, 0, 0, 0);
	var date2 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Unspecified);
    var date3 = DateTime.Now;
	var date4 = DateTime.UtcNow;
	var date5 = new DateTime(2017, 7, 11, 10, 0, 0, DateTimeKind.Unspecified);
	var date6 = new DateTime(2017, 7, 11, 10, 0, 0, DateTimeKind.Local);
	var date7 = new DateTime(2017, 7, 11, 10, 0, 0, DateTimeKind.Utc);

	
	date1.Kind.Dump();
	date2.Kind.Dump();
	date3.Kind.Dump();
	date4.Kind.Dump();
	date5.Kind.Dump();
	date6.Kind.Dump();
	date7.Kind.Dump();
	
	date1.ToUniversalTime().Dump();
	date2.ToUniversalTime().Dump();
	date3.ToUniversalTime().Dump();
	date4.ToUniversalTime().Dump();
	date5.ToUniversalTime().Dump();
	date6.ToUniversalTime().Dump();
	date7.ToUniversalTime().Dump();
}

// Define other methods and classes here
