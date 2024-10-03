using System;

class CollegeGradingSystem
{
    static void Main(string[] args)
    {
        // Prompt the user for their grade
        Console.Write("Enter your grade: ");
        string input = Console.ReadLine();

        // Check for special cases first
        if (input.ToUpper() == "INC")
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your status is Incomplete (INC)");
        }
        else if (input.ToUpper() == "DRP")
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your status is Dropped (DRP)");
        }
        else
        {
            // Try to parse the input as a double
            double grade;
            if (double.TryParse(input, out grade))
            {
                // Check if the grade is within the valid range
                if (grade < 69.0 || grade > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid grade between 69 and 100.");
                }
                else
                {
                    // Determine the grade description
                    string description;
                    if (grade <= 100 && grade >= 99.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "1.00";
                    }
                    else if (grade <= 98.9 && grade >= 96.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "1.25";
                    }
                    else if (grade <= 95.9 && grade >= 93.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "1.50";
                    }
                    else if (grade <= 92.9 && grade >= 90.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "1.75";
                    }
                    else if (grade <= 89.9 && grade >= 87.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "2.00";
                    }
                    else if (grade <= 86.9 && grade >= 84.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "2.25";
                    }
                    else if (grade <= 83.9 && grade >= 81.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "2.50";
                    }
                    else if (grade <= 80.9 && grade >= 78.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        description = "2.75";
                    }
                    else if (grade <= 77.9 && grade >= 75.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        description = "3.00";
                    }
                    else if (grade <= 74.9 && grade >= 70.0)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        description = "4.00";
                    }
                    else // grade == 69.0 and below
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        description = "Failed";
                    }

                    // Output the grade and its description
                    Console.WriteLine($"Your grade is {grade:F2} - {description}");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a numeric grade or INC/DRP.");
            }

        }
    }
}
