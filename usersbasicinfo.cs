using System;
using System.Linq;
class Program {
  public static void Main (string[] args) {
    Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Enter your nickname:");
        string myNickName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                   ");
        Console.WriteLine("Hello! " + myNickName);
        Console.WriteLine("                                   ");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Enter your age:");
        int myAge = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                   ");
        Console.WriteLine("Your age is " + myAge + " years old, too old ^^");
        Console.WriteLine("                                   ");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Enter your section:");
        string mySection = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                     ");
        Console.WriteLine("Your section is:  " + mySection + " that's cool!");
        Console.WriteLine("                                     ");


        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Do you want to see your basic information? Please enter again your age to proceed.");
        int deci = Convert.ToInt32(Console.ReadLine());

        if (deci >= 18)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Here's your basic information: ");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("You must be 18+ to proceed!");
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        string firstName = "Erickson Joseph Kristoffer";
        string lastName = " Luna";
        string fullName = firstName + lastName;
        Console.WriteLine(fullName);

        int age = 19;
        Console.WriteLine(age);

        string section = "BSCS - 1B";
        Console.WriteLine(section);

        Console.WriteLine("                     ");

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string sub1 = " Oral Communication,";
        string sub2 = " Basic-Calculus,";
        string sub3 = " General Biology,";
        string sub4 = " Earth Science,";
        string sub5 = " and Statistics and Probability!";
        Console.WriteLine("Your favorite subjects during SHS were " + sub1 + sub2 + sub3 + sub4 + sub5 + " That's great!");

        Console.WriteLine("                  ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Your grades are: ");

        Console.ForegroundColor = ConsoleColor.Gray;
        string subb1 = "Oral Communication:";
        Console.WriteLine(subb1);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string myStringA = "95";
        int number1 = Convert.ToInt32(myStringA);
        Console.WriteLine(myStringA);


        Console.ForegroundColor = ConsoleColor.Gray;
        string subb2 = "Basic-Calculus:";
        Console.WriteLine(subb2);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string myStringB = "98";
        int number2 = Convert.ToInt32(myStringB);
        Console.WriteLine(myStringB);

        Console.ForegroundColor = ConsoleColor.Gray;
        string subb3 = "General Biology:";
        Console.WriteLine(subb3);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string myStringC = "97";
        int number3 = Convert.ToInt32(myStringC);
        Console.WriteLine(myStringC);

        Console.ForegroundColor = ConsoleColor.Gray;
        string subb4 = "Earth Science:";
        Console.WriteLine(subb4);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string myStringD = "96";
        int number4 = Convert.ToInt32(myStringD);
        Console.WriteLine(myStringD);

        Console.ForegroundColor = ConsoleColor.Gray;
        string subb5 = "Statistics and Probability:";
        Console.WriteLine(subb5);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        string myStringE = "97";
        int number5 = Convert.ToInt32(myStringE);
        Console.WriteLine(myStringE);

        Console.WriteLine("                   ");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Do you want to know your average?");
        string average = Console.ReadLine();
        Console.WriteLine("              ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("OKAY! HERE IT IS:");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("The total sum of your grades is: ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int[] myGrades = { 95, 98, 97, 96, 97 };
        Console.WriteLine(myGrades.Sum());

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("The total average of your grades is: ");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        int[] myGradesA = { 95, 98, 97, 96, 97 };
        Console.WriteLine(myGradesA.Average());

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine("GOOD JOB!");

  }
}
