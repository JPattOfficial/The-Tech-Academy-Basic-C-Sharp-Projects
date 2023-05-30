using System;

class Program
{
    static void Main()
    {
        // Prompt for and retrieve user's age
        Console.WriteLine("What is your age?");
        string ageInput = Console.ReadLine();
        // Convert age input to integer
        bool isValidAge = int.TryParse(ageInput, out int age);

        // Prompt for and retrieve DUI status
        Console.WriteLine("Have you ever had a DUI? (true/false)");
        string duiInput = Console.ReadLine();
        // Convert DUI input to boolean
        bool isValidDui = bool.TryParse(duiInput, out bool hadDui);

        // Prompt for and retrieve speeding ticket count
        Console.WriteLine("How many speeding tickets do you have?");
        string ticketsInput = Console.ReadLine();
        // Convert speeding ticket input to integer
        bool isValidTickets = int.TryParse(ticketsInput, out int tickets);

        // Check if all inputs were valid
        if (!isValidAge || !isValidDui || !isValidTickets)
        {
            Console.WriteLine("Invalid input. Please enter valid values.");
            return;
        }

        // Business logic for qualifying for car insurance
        bool isQualified = (age > 15) && !hadDui && (tickets <= 3);

        // Print qualification status
        Console.WriteLine("Qualified?\n" + isQualified);
        Console.ReadLine();
    }
}