using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CLASS_SUBMISSION_ASSIGNMENT.MathOperations;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userInt))
            {
                math.DivideByTwo(userInt, out int intResult);
                Console.WriteLine("Your number divided by 2 is: " + intResult);
            }
            else if (double.TryParse(userInput, out double userDouble))
            {
                math.DivideByTwo(userDouble, out double doubleResult);
                Console.WriteLine("Your number divided by 2 is: " + doubleResult);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadLine();
        }
    }
}
