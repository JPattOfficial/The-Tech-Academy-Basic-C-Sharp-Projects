using System;

class Program
{
    static void Main()
    {
        // Requirement 1: Boolean comparison using a while statement
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine($"While loop count: {count}");
            Console.ReadLine();  // Add Console.ReadLine() here
            count++;
        }

        // Requirement 2: Boolean comparison using a do-while statement
        count = 0;
        do
        {
            Console.WriteLine($"Do-While loop count: {count}");
            Console.ReadLine();  // Add Console.ReadLine() here
            count++;
        } while (count < 10);

        // Requirement 3: A switch statement
        Console.WriteLine("Enter a number between 1 and 3:");
        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                Console.WriteLine("You entered one.");
                Console.ReadLine();  // Add Console.ReadLine() here
                break;
            case "2":
                Console.WriteLine("You entered two.");
                Console.ReadLine();  // Add Console.ReadLine() here
                break;
            case "3":
                Console.WriteLine("You entered three.");
                Console.ReadLine();  // Add Console.ReadLine() here
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                Console.ReadLine();  // Add Console.ReadLine() here
                break;
        }
    }
}
