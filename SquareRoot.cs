using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        double result = Sqrt(number, number / 2);
        Console.WriteLine($"The Square Root of {number} is {result}");
    }

    static double Sqrt(double number, double guess)
    {

        const double epsilon = 0.00001;

        double newGuess = (guess + number / guess) / 2;

        if (Math.Abs(newGuess - guess) < epsilon)
        {
            return newGuess;
        }

        return Sqrt(number, newGuess);
    }
}
