using System;

namespace Dollar_to_Peso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollar, exchange, num1 = 55.21;
            Console.WriteLine("Convert dollar to Peso");
            Console.ReadKey();

            Console.WriteLine("Please enter the amount in dollar:");
            dollar = Convert.ToDouble(Console.ReadLine());

            exchange = num1 * dollar;
            Console.WriteLine("The amount $" + dollar + " is " + exchange + " in peso");

        }
    }
}
