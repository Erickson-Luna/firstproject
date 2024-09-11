using System;

namespace Number3
{
    class ArithmeticOperators
    {
        static void Main(string[] args)
        {
            //Program to demonstrate all Arithmetic Operators using Basic Input/Output
            int A, B, C, D, E, F, G;
            Console.WriteLine("Enter the value of A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the value of B: ");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Addition
            C = A + B;
            Console.WriteLine();
            //Subtraction
            D = A - B;
            Console.WriteLine();
            //Multiplication
            E = A * B;
            Console.WriteLine();
            //Division
            F = A / B;
            Console.WriteLine();
            //Modulus
            G = A % B;
            Console.WriteLine();

            Console.WriteLine("The Sum is: {0}", C);
            Console.WriteLine();
            Console.WriteLine("The Difference is: {0}", D);
            Console.WriteLine();
            Console.WriteLine("The Product is: {0}", E);
            Console.WriteLine();
            Console.WriteLine("The Quotient is: {0}", F);
            Console.WriteLine();
            Console.WriteLine("The Remainder is: {0}", G);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
