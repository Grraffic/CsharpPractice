using System;

class OperatorPractical
{   
    static void Main(string[] args)
    {
        int math = 85;
        int science = 90;
        int english = 78;
        int totalSubjects = 3;

        Console.WriteLine($"Total Score: {math + science + english}");
        Console.WriteLine($"Average Score: {(double)(math + science + english) / totalSubjects:F2}");
        Console.WriteLine($"Score Difference: {math - english}");
        Console.WriteLine($"Score Multiplication: {math * english}");
        Console.WriteLine($"Remainder: {science % 7}");
    }
}