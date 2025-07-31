using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Triangle Type Identifier");
        
        int side1, side2, side3;

        // Get side 1 with validation
        Console.Write("Enter side 1: ");
        while (!int.TryParse(Console.ReadLine(), out side1))
        {
            Console.WriteLine("Invalid input. Enter a number:");
        }

        // Get side 2 with validation
        Console.Write("Enter side 2: ");
        while (!int.TryParse(Console.ReadLine(), out side2))
        {
            Console.WriteLine("Invalid input. Enter a number:");
        }

        // Get side 3 with validation
        Console.Write("Enter side 3: ");
        while (!int.TryParse(Console.ReadLine(), out side3))
        {
            Console.WriteLine("Invalid input. Enter a number:");
        }

        // Determine triangle type
        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Type: Equilateral");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("Type: Isosceles");
        else
            Console.WriteLine("Type: Scalene");
    }
}