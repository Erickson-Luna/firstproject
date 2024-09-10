using System;

namespace DollarToPeso
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double dollar, exchange, num1 = 56.488995;
            Console.WriteLine("Conversion of Dollar to Peso");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Please enter the amount in Dollar: ");
            dollar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            exchange = dollar * num1;
            Console.WriteLine("The amount $" + dollar + " is " + exchange + " in Philippine Peso");
        }
    }
}
