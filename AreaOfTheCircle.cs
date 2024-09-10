using System;

namespace AreaoftheCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate the area of the circle
            double radius, area;
            Console.WriteLine("Enter the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radius * radius;

            Console.WriteLine();
            Console.WriteLine("The Area of the Circle with radius {0} is equal to {1}", radius, area);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
