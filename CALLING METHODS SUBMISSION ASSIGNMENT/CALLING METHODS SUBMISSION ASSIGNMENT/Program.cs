using System;

namespace CALLING_METHODS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int result1 = math.AddTen(userInput);
            Console.WriteLine("Your number + 10 is: " + result1);

            int result2 = math.MultiplyByFive(userInput);
            Console.WriteLine("Your number * 5 is: " + result2);

            int result3 = math.SubtractThree(userInput);
            Console.WriteLine("Your number - 3 is: " + result3);

            Console.ReadLine();
        }
    }
}