using System.Collections.Generic;

Dictionary<string, byte> agesByNames = new Dictionary<string, byte> () {{"Aygün Bilir", 36}};

agesByNames.Add("Ayhan Bilir", 99);

agesByNames.Add("Hakan Bilir", 19);

if (agesByNames.ContainsKey("Ayben Güler"))
{
    System.Console.WriteLine(agesByNames["Ayben Güler"]);
  
} else
{
    System.Console.WriteLine("Person doesn't exist!");
}

// dotnet run
