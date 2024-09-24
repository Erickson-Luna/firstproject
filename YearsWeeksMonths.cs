using System;

namespace CnvrtYearWeekDay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            double totalDays = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double years = 365.25;
            double weeks = 7;
            double months = 30.417;

            double result1 = totalDays / years;
            double result2 = totalDays / weeks;
            double result3 = totalDays / months;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(totalDays + " days is approximately:");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{result1:F1} years");
            Console.WriteLine();
            Console.WriteLine($"{result2:F1} weeks");
            Console.WriteLine();
            Console.WriteLine($"{result3:F1} months");

        }
    }
}
