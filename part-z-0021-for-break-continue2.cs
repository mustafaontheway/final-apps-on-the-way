var sumEvens = 0;

var sumOdds = 0;

for (byte i = 0; i < 20; i++)
{
    if (i % 2 == 0) { sumEvens += i; }

    else { sumOdds += i; }
}

System.Console.WriteLine($"Sum of even numbers: {sumEvens}");

System.Console.WriteLine($"Sum of odd numbers: {sumOdds}");

// Sum of even numbers: 90
// Sum of odd numbers: 100
