using METHOD_SUBMISSION_ASSIGNMENT;
using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number (or just hit enter to skip): ");
            string number2Input = Console.ReadLine();

            if (string.IsNullOrEmpty(number2Input)) // If the user skips the second number
            {
                int result = math.DoOperation(number1);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                int number2 = Convert.ToInt32(number2Input);
                int result = math.DoOperation(number1, number2);
                Console.WriteLine("Result: " + result);
            }
            Console.ReadLine();
        }
    }
}
