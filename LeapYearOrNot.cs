using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (IsLeapYear(year))
        {
            Console.WriteLine();
            Console.WriteLine("It's a leap year.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Not a leap year.");
        }
    }

    static bool IsLeapYear(int year)
    {
        // A year is a leap year if:
        // 1. It is divisible by 4
        // 2. It is not divisible by 100, unless it is also divisible by 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
