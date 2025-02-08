using System;
using System.Threading;

class Program
{
    static void Main()
    {

        int size = 10;

        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= size; j++)
            {

                Console.Write($"{i * j}\t");

                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}
