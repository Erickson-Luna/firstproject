using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a letter: ");
        char input = Console.ReadKey().KeyChar; // Read a single character from the user
        Console.WriteLine(); // Move to the next line

        // Check if the input is a letter
        if (char.IsLetter(input))
        {
            // Convert the character to lowercase for easier comparison
            char lowerInput = char.ToLower(input);

            // Determine if it's a vowel or consonant
            if (lowerInput == 'a' || lowerInput == 'e' || lowerInput == 'i' || lowerInput == 'o' || lowerInput == 'u')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine($"{input} is a vowel.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine($"{input} is a consonant.");
            }
        }
        else
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid letter.");
        }
    }
}
