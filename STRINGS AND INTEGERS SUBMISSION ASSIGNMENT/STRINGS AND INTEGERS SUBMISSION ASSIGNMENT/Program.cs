using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> intsList = new List<int> { 2, 4, 6, 8 };

        Console.WriteLine("Enter a number to divide the numbers 2, 4, 6, and 8 by: ");
        string input = Console.ReadLine();
        int divider = Int32.Parse(input);

        foreach (int num in intsList)
        {
            Console.WriteLine(num + " divided by " + divider + " is " + num / divider);
        }
        Console.ReadLine();

    }
}
