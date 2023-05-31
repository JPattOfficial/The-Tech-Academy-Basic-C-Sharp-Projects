using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for and retrieve package weight
        Console.WriteLine("Please enter the package weight:");
        bool isWeightValid = decimal.TryParse(Console.ReadLine(), out decimal weight);

        // Check weight
        if (!isWeightValid || weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        }

        Console.ReadLine();

        // Prompt for and retrieve package width
        Console.WriteLine("Please enter the package width:");
        bool isWidthValid = decimal.TryParse(Console.ReadLine(), out decimal width);

        // Prompt for and retrieve package height
        Console.WriteLine("Please enter the package height:");
        bool isHeightValid = decimal.TryParse(Console.ReadLine(), out decimal height);

        // Prompt for and retrieve package length
        Console.WriteLine("Please enter the package length:");
        bool isLengthValid = decimal.TryParse(Console.ReadLine(), out decimal length);

        // Check if all inputs were valid
        if (!isWidthValid || !isHeightValid || !isLengthValid)
        {
            Console.WriteLine("Invalid input. Please enter valid values.");
            Console.ReadLine();
        }

        Console.ReadLine();

        // Check dimensions
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            Console.ReadLine();
        }

        Console.ReadLine();

        // Calculate quote
        decimal quote = (width * height * length * weight) / 100;

        // Print quote
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");

        Console.ReadLine();
    }
}
