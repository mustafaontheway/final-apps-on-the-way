byte month = 17;

string result = month switch
{
    12 or 1 or 2 => "Winter",
    3 or 4 or 5  => "Spring",
    6 or 7 or 8  => "Summer",
    9 or 10 or 11 => "Fall",
    _ => "Use a number b/w 1 and 12" // _ means "default"
};

System.Console.WriteLine(result);

// dotnet run
