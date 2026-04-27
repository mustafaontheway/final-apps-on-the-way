string? userName = null ?? "dear user";

string message1 = $"Welcome {userName}!";

System.Console.WriteLine(message1);

userName = "Ayhan";

string message2 = $"Welcome {userName}!";

System.Console.WriteLine(message2);

// Welcome dear user!
// Welcome Ayhan!


// dotnet run 
