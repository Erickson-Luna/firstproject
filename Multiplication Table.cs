using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("              MULTIPLICATION TABLE            ");
        Console.WriteLine();
        Console.Write("Enter a number to generate multiplication tables you want to see: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int size = 10;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{i * j}\t");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
