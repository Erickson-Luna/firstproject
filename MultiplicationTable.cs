using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to print its multiplication table:");
        Console.WriteLine();
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"{number} × {i} = {number * i}");
        }
    }
}
