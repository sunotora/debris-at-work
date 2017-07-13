<Query Kind="Program" />

void Main()
{
    var unixTime = (DateTime.UtcNow - DateTime.Now).TotalSeconds;
	var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	var localDateTime = unixEpoch.AddSeconds( unixTime ).ToLocalTime().Dump();
	localDateTime.GetType().Dump();
	localDateTime.Kind.Dump();

    "-------".Dump();

	var utcDateTime = unixEpoch.AddSeconds( unixTime ).ToUniversalTime().Dump();
	utcDateTime.GetType().Dump();
	utcDateTime.Kind.Dump();


}


// Define other methods and classes here
