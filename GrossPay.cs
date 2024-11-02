using System;

class EmployeePayCalculator
{
    static void Main()
    {
        // Get employee's hourly wage in PHP
        Console.Write("Enter hourly wage (in PHP): ");
        double hourlyWage = Convert.ToDouble(Console.ReadLine());

        // Get number of hours worked in a day
        Console.Write("Enter hours worked in a day: ");
        double hoursWorked = Convert.ToDouble(Console.ReadLine());

        // Calculate gross pay
        double grossPay = CalculateGrossPay(hourlyWage, hoursWorked);

        // Display the gross pay in PHP
        Console.WriteLine($"Gross Pay: ₱{grossPay:F2}");
    }

    static double CalculateGrossPay(double wage, double hours)
    {
        const double overtimeRate = 1.5;
        double regularHours = Math.Min(hours, 8);
        double overtimeHours = Math.Max(0, hours - 8);

        return (regularHours * wage) + (overtimeHours * wage * overtimeRate);
    }
}
