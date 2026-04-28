byte counter = 0;

while (counter < 20)
{
    counter += 2;

    if (counter == 8) { continue; }

    if (counter == 14) { break; }

    System.Console.WriteLine($"Counter value: {counter}");
}

// Counter value: 2
// Counter value: 4
// Counter value: 6
// Counter value: 10
// Counter value: 12
