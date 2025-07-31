using System;

class Program
{
    static void Main()
    {
        // Display program title
        Console.WriteLine("Grade Calculator");
        
        // Declare variable to store grade
        int grade;
        
        // Prompt user and validate input
        Console.Write("Enter your numerical grade (0-100): ");
        
        // Keep asking for input until valid number between 0-100 is provided
        while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Enter a number between 0 and 100:");
        }

        // Determine and display grade
        if (grade >= 90)
            Console.WriteLine("Grade: A");
        else if (grade >= 80)
            Console.WriteLine("Grade: B");
        else if (grade >= 70)
            Console.WriteLine("Grade: C");
        else if (grade >= 60)
            Console.WriteLine("Grade: D");
        else
            Console.WriteLine("Grade: F");
    }
}