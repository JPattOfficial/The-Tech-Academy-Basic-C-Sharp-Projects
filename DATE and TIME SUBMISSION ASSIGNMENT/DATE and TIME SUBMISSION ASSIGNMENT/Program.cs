using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get current date and time
            DateTime now = DateTime.Now;
            // Print current date and time to console
            Console.WriteLine("Current date and time: " + now);

            // Ask the user for a number
            Console.Write("Enter a number of hours: ");
            string input = Console.ReadLine();

            // Convert input string to integer
            int hours;
            if (Int32.TryParse(input, out hours))
            {
                // Calculate time after x hours
                DateTime futureTime = now.AddHours(hours);
                // Print future time to console
                Console.WriteLine("In " + hours + " hours, it will be: " + futureTime);
            }
            else
            {
                // Handle invalid input
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
            Console.ReadLine();
        }
    }
}