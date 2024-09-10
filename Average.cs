using System;

namespace AveofthreeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Compute the average of three integer number: ");
            Console.WriteLine();

            Console.WriteLine("Enter the first number: ");
            double G1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the second number: ");
            double G2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the third number: ");
            double G3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double Average = (G1 + G2 + G3) / 3;
            Console.WriteLine("The average of three numbers you've entered is " + Average);

        }
    }
}
