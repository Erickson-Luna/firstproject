using System;

namespace Number2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string myName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello! " + myName);
            Console.WriteLine();


            Console.WriteLine("Enter your age:");
            int myAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your age is " + myAge + " years old");
            Console.WriteLine();

            char MyChar = 'E';
            Console.WriteLine("The first letter of your name is " + MyChar);
            Console.WriteLine();

            float MyFloat = 3.14F;
            Console.WriteLine("Float: " + MyFloat);
            Console.WriteLine();

            double MyDouble = 11.1;
            Console.WriteLine("Double: " + MyDouble);
            Console.WriteLine();

            bool MyBool = false;
            Console.WriteLine("Boolean: " + MyBool);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
