byte[] grades = new byte[10];

void setGrades(byte index, byte grade)
{
    if (index < (byte) 10 && (byte) grade <= 100)
    {
        grades[index] = grade;
    } 

    if (index > 9 )
    {
        System.Console.WriteLine("We have 10 students...");
    }

    if (grade > 100)
    {
        System.Console.WriteLine("Student grade must be between 0 and 100.");
    }
}

setGrades(4, 72);

System.Console.WriteLine(grades[4]);

setGrades(111, 99);

setGrades(7, 105);

System.Console.WriteLine(grades[7]);

System.Console.WriteLine("-------------------------");

setGrades(17, 140);

// 72
// We have 10 students...
// Student grade must be between 0 and 100.
// -------------------------
// We have 10 students...
// Student grade must be between 0 and 100.
