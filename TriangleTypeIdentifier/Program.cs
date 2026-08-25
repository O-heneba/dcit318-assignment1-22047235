using System;

class Program
{
    static void Main()
    {
        // Read three side lengths from the user
        double side1 = ReadPositiveDouble("Enter the first side: ");
        double side2 = ReadPositiveDouble("Enter the second side: ");
        double side3 = ReadPositiveDouble("Enter the third side: ");

        // Validate triangle inequality
        if (!IsValidTriangle(side1, side2, side3))
        {
            Console.WriteLine("The provided sides do not form a valid triangle.");
            return;
        }

        // Determine triangle type
        string type;
        if (side1 == side2 && side2 == side3)
        {
            type = "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            type = "Isosceles";
        }
        else
        {
            type = "Scalene";
        }

        Console.WriteLine($"Triangle Type: {type}");
    }

    // Helper to read a positive double value from console
    static double ReadPositiveDouble(string prompt)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (!double.TryParse(input, out double value) || value <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a number greater than 0.");
            Environment.Exit(0);
        }

        return value;
    }

    // Check triangle inequality
    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
