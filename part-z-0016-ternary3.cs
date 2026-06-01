byte[] grades = new byte[10];

grades[0] = 99;
grades[4] = 77;
grades[6] = 100;
grades[8] = 65;
grades[9] = 14;

foreach (byte grade in grades)
{ 
    System.Console.WriteLine(grade <= 70 ? "Fail" : $"Success... His/her grade: {grade}");
}

// Success... His/her grade: 99
// Fail
// Fail
// Fail
// Success... His/her grade: 77
// Fail
// Success... His/her grade: 100
// Fail
// Fail
// Fail
