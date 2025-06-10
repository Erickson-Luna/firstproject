using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the GWA Calculator!");
        Console.WriteLine();
        Console.WriteLine("Enter your grades and units for each subject.");
        Console.WriteLine();
        Console.WriteLine("Type 'done' when you are finished.\n");

        double totalWeightedGrades = 0;
        double totalUnits = 0;

        while (true)
        {
            Console.Write("Enter your grade: ");
            string gradeInput = Console.ReadLine().Trim().ToUpper();

            if (gradeInput == "DONE")
                break;

            // Handle special grades
            if (gradeInput == "INC" || gradeInput == "DRP")
            {
                Console.WriteLine($"Grade status: {gradeInput}\n");
                continue;
            }

            // Try parsing the numeric grade
            if (!double.TryParse(gradeInput, out double grade))
            {
                Console.WriteLine("Invalid input. Please enter a valid grade.\n");
                continue;
            }

            // Check for valid grade range
            if (grade < 1.00 || grade > 5.00)
            {
                Console.WriteLine("Grade out of range. Must be between 1.00 and 5.00.\n");
                continue;
            }

            // Ask for units
            Console.Write("Enter units earned for this subject: ");
            if (!double.TryParse(Console.ReadLine(), out double units) || units <= 0)
            {
                Console.WriteLine("Invalid units. Please enter a positive number.\n");
                continue;
            }

            // Get grade status
            string status = GetStatus(grade);
            Console.WriteLine($"Grade status: {status}\n");

            // Accumulate for GWA calculation (only numeric, not INC/DRP)
            totalWeightedGrades += grade * units;
            totalUnits += units;
        }

        if (totalUnits > 0)
        {
            double gwa = totalWeightedGrades / totalUnits;
            Console.WriteLine($"\nYour General Weighted Average (GWA) is: {gwa:F2}");
        }
        else
        {
            Console.WriteLine("\nNo valid grades entered to compute GWA.");
        }

        Console.WriteLine("\nThank you for using the GWA Calculator!");
    }

    static string GetStatus(double grade)
    {
        if (grade == 1.00 || grade == 1.25)
            return "Excellent";
        else if (grade == 1.50 || grade == 1.75)
            return "Very Satisfactory";
        else if (grade == 2.00 || grade == 2.25)
            return "Satisfactory";
        else if (grade == 2.50 || grade == 2.75 || grade == 3.00)
            return "Fairly Satisfactory";
        else if (grade == 4.00)
            return "Conditional Failure";
        else // grade == 5.00
            return "Failed";
    }
}
