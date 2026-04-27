byte month = 2;

switch (month)
{
    case 12 or 1 or 2:
        System.Console.WriteLine("Winter");
        break;

    case 3 or 4 or 5:
        System.Console.WriteLine("Spring");
        break;

    case 6 or 7 or 8:
        System.Console.WriteLine("Summer");
        break;

    case 9 or 10 or 11:
        System.Console.WriteLine("Fall");
        break;

    default:
        System.Console.WriteLine("Use a number b/w 1 and 12");
        break;
}

// dotnet run
