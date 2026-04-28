using System.Collections.Generic;

Dictionary<string, byte> agesByNames = new Dictionary<string, byte> () {{"Aygün Bilir", 36}};

agesByNames.Add("Ayhan Bilir", 99);

agesByNames.Add("Hakan Bilir", 19);

if (agesByNames.Remove("Ayhan Bilir", out byte age))
{
    System.Console.WriteLine("Person deleted!");
}

System.Console.WriteLine($"When my grand-father died, he was {age}."); 

// Person deleted!
// When my grand-father died, he was 99.

// dotnet run
