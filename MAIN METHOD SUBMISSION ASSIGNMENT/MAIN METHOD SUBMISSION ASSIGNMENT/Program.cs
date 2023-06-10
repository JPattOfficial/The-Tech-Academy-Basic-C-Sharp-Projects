using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            // Calling the method with an integer parameter
            int result1 = math.DoOperation(5);
            Console.WriteLine("Result of operation on integer: " + result1);

            // Calling the method with a decimal parameter
            int result2 = math.DoOperation(7.6m); // 'm' denotes a decimal literal
            Console.WriteLine("Result of operation on decimal: " + result2);

            // Calling the method with a string parameter
            int result3 = math.DoOperation("9");
            Console.WriteLine("Result of operation on string: " + result3);

            Console.ReadLine();
        }
    }
}