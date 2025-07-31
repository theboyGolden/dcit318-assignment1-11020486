using System;

class Program
{
    static void Main()
    {
        // Display program title
        Console.WriteLine("Ticket Price Calculator");
        
        // Declare variable to store age
        int age;
        
        // Prompt user and validate input
        Console.Write("Enter your age: ");
        
        // Keep asking for input until valid positive number is provided
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.WriteLine("Invalid input. Enter a positive number:");
        }

        // Calculate ticket price based on age
        int price = (age <= 12 || age >= 65) ? 7 : 10;
        
        // Display the calculated price
        Console.WriteLine($"Ticket Price: GHC{price}");
    }
}