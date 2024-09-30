using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0) // Check if input is a non-negative integer
        {
            // Calculate the square root
            double sqrt = Math.Sqrt(number);
            // Check if the square of the integer part of the square root equals the original number
            bool isPerfectSquare = (sqrt % 1 == 0);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"{number} is {(isPerfectSquare ? "a perfect square." : "not a perfect square.")}");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Please enter a valid non-negative integer.");
        }
    }
}
