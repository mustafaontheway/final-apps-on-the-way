using System.Collections.Generic;

Dictionary<string, byte> agesByNames = new Dictionary<string, byte> () {{"Aygün Bilir", 36}};

agesByNames.Add("Ayhan Bilir", 99);

agesByNames.Add("Hakan Bilir", 19);

System.Console.WriteLine(agesByNames["Aygün Bilir"]); // 36
