using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        // Read input from the user
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int number))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You entered: " + number);
            Console.WriteLine();
            Console.WriteLine("The entered number is an integer.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("The entered value is not a valid integer.");
        }
    }
}
