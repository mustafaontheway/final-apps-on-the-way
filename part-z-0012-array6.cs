byte[] grades = {77, 87, 0, 99, 45, 65, 100, 88};

byte maxGrade = grades[0];

byte maxIndex = 0;

for (byte i = 1; i < grades.Length; i++)
{
    if (grades[i] > maxGrade)
    {
        maxGrade = grades[i];
        maxIndex = i;
    }
}

System.Console.WriteLine(maxGrade);
System.Console.WriteLine(maxIndex);

// 100
// 6
