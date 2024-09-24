using System;

namespace Multiplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int result = num1 * num2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The product of {0} and {1} is {2}", num1, num2, result);

        }
    }
}
