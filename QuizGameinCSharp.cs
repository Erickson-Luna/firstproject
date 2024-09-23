using System;

namespace CSharpQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Quiz!");
            Console.WriteLine("Answer the following questions about C# history and syntax:");
            Console.WriteLine();

            int score = 0;

            // Question 1
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Who developed C#?");
            Console.WriteLine("a) Sun Microsystems");
            Console.WriteLine("b) Microsoft");
            Console.WriteLine("c) IBM");
            Console.WriteLine("d) Apple");
            Console.Write("Your answer (a/b/c/d): ");
            string answer1 = Console.ReadLine();
            if (answer1.ToLower() == "b")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is b) Microsoft.");
            }
            Console.WriteLine();

            // Question 2
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("2. What year was C# first released?");
            Console.WriteLine("a) 2000");
            Console.WriteLine("b) 2005");
            Console.WriteLine("c) 2002");
            Console.WriteLine("d) 2010");
            Console.Write("Your answer (a/b/c/d): ");
            string answer2 = Console.ReadLine();
            if (answer2.ToLower() == "c")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is c) 2002.");
            }
            Console.WriteLine();

            // Question 3
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("3. Which keyword is used to define a class in C#?");
            Console.WriteLine("a) class");
            Console.WriteLine("b) structure");
            Console.WriteLine("c) define");
            Console.WriteLine("d) object");
            Console.Write("Your answer (a/b/c/d): ");
            string answer3 = Console.ReadLine();
            if (answer3.ToLower() == "a")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is a) class.");
            }
            Console.WriteLine();

            // Question 4
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("4. Which keyword is used to create an instance of a class?");
            Console.WriteLine("a) new");
            Console.WriteLine("b) instance");
            Console.WriteLine("c) create");
            Console.WriteLine("d) make");
            Console.Write("Your answer (a/b/c/d): ");
            string answer4 = Console.ReadLine();
            if (answer4.ToLower() == "a")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is a) new.");
            }
            Console.WriteLine();

            // Question 5
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("5. What is the default access modifier for class members in C#?");
            Console.WriteLine("a) internal");
            Console.WriteLine("b) protected");
            Console.WriteLine("c) public");
            Console.WriteLine("d) private");
            Console.Write("Your answer (a/b/c/d): ");
            string answer5 = Console.ReadLine();
            if (answer5.ToLower() == "d")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is d) private.");
            }
            Console.WriteLine();

            // Question 6
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("6. What is the print statement for C#?");
            Console.WriteLine("a) print();");
            Console.WriteLine("b) System.out.println();");
            Console.WriteLine("c) Console.WriteLine();");
            Console.WriteLine("d) console.log();");
            Console.Write("Your answer (a/b/c/d): ");
            string answer6 = Console.ReadLine();
            if (answer6.ToLower() == "c")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is c) Console.WriteLine();.");
            }
            Console.WriteLine();

            // Question 7
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("7. Which keyword is used to define a method that does not return a value in C#?");
            Console.WriteLine("a) void");
            Console.WriteLine("b) static");
            Console.WriteLine("c) class");
            Console.WriteLine("d) new");
            Console.Write("Your answer (a/b/c/d): ");
            string answer7 = Console.ReadLine();
            if (answer7.ToLower() == "a")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is a) void.");
            }
            Console.WriteLine();

            // Question 8
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("8. What type of loop in C# will always execute atleast once?");
            Console.WriteLine("a) for-each");
            Console.WriteLine("b) while");
            Console.WriteLine("c) for");
            Console.WriteLine("d) do-while");
            Console.Write("Your answer (a/b/c/d): ");
            string answer8 = Console.ReadLine();
            if (answer8.ToLower() == "d")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is d) do-while.");
            }
            Console.WriteLine();

            // Question 9
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("9. What symbol is used to indicate a comment in C#? (in multi lines)");
            Console.WriteLine("a) #");
            Console.WriteLine("b) //");
            Console.WriteLine("c) /* */");
            Console.WriteLine("d) :)");
            Console.Write("Your answer (a/b/c/d): ");
            string answer9 = Console.ReadLine();
            if (answer9.ToLower() == "c")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is c) /* */");
            }
            Console.WriteLine();

            // Question 10
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("10. Who is the principal inventor of C#?");
            Console.WriteLine("a) Anders Hejlsberg");
            Console.WriteLine("b) James Gosling");
            Console.WriteLine("c) Guido van Rossum");
            Console.WriteLine("d) Dennis Ritchie");
            Console.Write("Your answer (a/b/c/d): ");
            string answer10 = Console.ReadLine();
            if (answer10.ToLower() == "a")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is a) Anders Hejlsberg. ");
            }
            Console.WriteLine();

            // Question 11
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("11. If you don't want others (or yourself) to overwrite existing values, you can add the ___ keyword in front of the variable type.");
            Console.WriteLine("a) MyNum");
            Console.WriteLine("b) const");
            Console.WriteLine("c) Math.Max();");
            Console.WriteLine("d) backslash t");
            Console.Write("Your answer (a/b/c/d): ");
            string answer11 = Console.ReadLine();
            if (answer11.ToLower() == "b")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is b) const. ");
            }
            Console.WriteLine();

            // Question 12
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("12. Compact and informal high-level description of a computer programming. It is also intended for human reading rather than machine reading. ");
            Console.WriteLine("a) Programming");
            Console.WriteLine("b) Algorithm");
            Console.WriteLine("c) Pseudocode");
            Console.WriteLine("d) Flowchart");
            Console.Write("Your answer (a/b/c/d): ");
            string answer12 = Console.ReadLine();
            if (answer12.ToLower() == "c")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is c) Pseudocode.");
            }
            Console.WriteLine();

            // Question 13
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("13. What type of error was commonly encountered by a programmer?");
            Console.WriteLine("a) Run-time error");
            Console.WriteLine("b) Syntax error");
            Console.WriteLine("c) Logic error");
            Console.WriteLine("d) Love error");
            Console.Write("Your answer (a/b/c/d): ");
            string answer13 = Console.ReadLine();
            if (answer13.ToLower() == "b")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is b) Syntax error.");
            }
            Console.WriteLine();

            // Question 14
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("14. How do you create a variable with the floating number 2.8?");
            Console.WriteLine("a) int x = 2.8D;");
            Console.WriteLine("b) int x = 2.8;");
            Console.WriteLine("c) double x = 2.8D;");
            Console.WriteLine("d) byte x = 2.8;");
            Console.Write("Your answer (a/b/c/d): ");
            string answer14 = Console.ReadLine();
            if (answer14.ToLower() == "c")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is c) double x = 2.8D;.");
            }
            Console.WriteLine();

            // Question 15
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("15. What is the name of the 'special' class that represents a group of constants?");
            Console.WriteLine("a) const");
            Console.WriteLine("b) special");
            Console.WriteLine("c) enum");
            Console.WriteLine("d) void");
            Console.Write("Your answer (a/b/c/d): ");
            string answer15 = Console.ReadLine();
            if (answer15.ToLower() == "c")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is c) enum.");
            }
            Console.WriteLine();

            // Bonus Question
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("16. (Bonus Question): What is my favorite song? ");
            Console.WriteLine("a) Locked Down of Heaven by Bruno Mars");
            Console.WriteLine("b) Tahanan by Adie");
            Console.WriteLine("c) Alapaap by Eraserheads");
            Console.WriteLine("d) Crazy Stupid Love by TWICE");
            Console.Write("Your answer (a/b/c/d): ");
            string answer16 = Console.ReadLine();
            if (answer16.ToLower() == "a")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect. The correct answer is a) Locked Down of Heaven by Bruno Mars.");
            }
            Console.WriteLine();

            // Display the final score
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine($"You scored {score} out of 15.");
            Console.WriteLine();
            Console.WriteLine("Thank you for taking the quiz!");
        }
    }
}
