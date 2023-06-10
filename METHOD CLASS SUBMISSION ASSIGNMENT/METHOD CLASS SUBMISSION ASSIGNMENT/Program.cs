using METHOD_CLASS_SUBMISSION_ASSIGNMENT;
using System;


namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            // Call the method in the class, passing in two numbers.
            math.DoOperation(5, 10);

            // Call the method in the class, specifying the parameters by name.
            math.DoOperation(number1: 3, number2: 6);

            Console.ReadLine();
        }
    }
}