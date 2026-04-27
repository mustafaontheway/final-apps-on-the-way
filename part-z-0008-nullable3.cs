uint? fixedCost = null;

uint? expectedSales = 7_250_000;

uint profit = (expectedSales ?? 0) - (fixedCost ?? 0);

System.Console.WriteLine(profit); // 7250000


// dotnet run 
