using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is odd or even:");

        // Read user input
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int number))
        {
            // Determine if the number is odd or even
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    }
}
