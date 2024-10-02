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
            // Try to parse the input as a decimal
            decimal grade;
            if (decimal.TryParse(input, out grade))
            {
                // Check if the grade is within the valid range
                if (grade < 1.00m || grade > 5.00m)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid grade between 1.00 and 5.00.");
                }
                else
                {
                    // Determine the grade description
                    string description;
                    if (grade >= 1.00m && grade <= 1.49m)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "Excellent";
                    }
                    else if (grade >= 1.50m && grade <= 1.99m)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "Very Satisfactory";
                    }
                    else if (grade >= 2.00m && grade <= 2.49m)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        description = "Satisfactory";
                    }
                    else if (grade >= 2.50m && grade <= 3.00m)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        description = "Fairly Satisfactory";
                    }
                    else if (grade == 4.00m)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        description = "Conditional Failure";
                    }
                    else // grade == 5.00m
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
