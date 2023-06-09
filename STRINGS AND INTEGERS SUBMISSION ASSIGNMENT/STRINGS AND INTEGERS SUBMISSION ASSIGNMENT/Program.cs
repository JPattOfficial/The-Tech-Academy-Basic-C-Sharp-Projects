using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> intsList = new List<int> { 2, 4, 6, 8 };

        try
        {
            Console.WriteLine("Enter a number to divide the numbers 2, 4, 6, and 8 by: ");
            string input = Console.ReadLine();
            int divider = Int32.Parse(input);

            foreach (int num in intsList)
            {
                Console.WriteLine(num + " divided by " + divider + " is " + num / divider);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
    }
}
