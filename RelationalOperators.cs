using System;

class Program
{
    static void Main()
    {
        int a = 14;
        int b = 6;

        Console.WriteLine("a = 14, b = 6");
        Console.WriteLine("a == b: " + (a == b));  // Equal to
        Console.WriteLine("a != b: " + (a != b));  // Not equal to
        Console.WriteLine("a > b: " + (a > b));    // Greater than
        Console.WriteLine("a < b: " + (a < b));    // Less than
        Console.WriteLine("a >= b: " + (a >= b));  // Greater than or equal to
        Console.WriteLine("a <= b: " + (a <= b));  // Less than or equal to
    }
}
