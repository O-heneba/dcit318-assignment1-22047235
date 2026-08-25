using System;

class Program
{
    static void Main()
    {
        // Ask for the user's age
        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();

        if (!int.TryParse(input, out int age))
        {
            Console.WriteLine("Invalid input. Please enter a valid whole number for age.");
            return;
        }

        if (age < 0)
        {
            Console.WriteLine("Age cannot be negative.");
            return;
        }

        // Determine ticket price
        const int normalPrice = 10;
        const int discountedPrice = 7;
        int price;

        if (age <= 12 || age >= 65)
        {
            price = discountedPrice;
        }
        else
        {
            price = normalPrice;
        }

        Console.WriteLine($"Ticket Price: GHC{price}");
    }
}
