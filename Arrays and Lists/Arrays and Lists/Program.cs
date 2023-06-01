using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] strArray = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        // Ask the user to select an index of the array
        Console.WriteLine("Please enter an index for the string array (0 - 4): ");
        int index = Convert.ToInt32(Console.ReadLine());

        // Display the string at that index on the screen
        if (index >= 0 && index < strArray.Length)
        {
            Console.WriteLine($"Selected string: {strArray[index]}");
        }
        else
        {
            Console.WriteLine("This index doesn't exist in the string array.");
        }

        // Create a one-dimensional array of integers
        int[] intArray = { 1, 2, 3, 4, 5 };

        // Ask the user to select an index of the array
        Console.WriteLine("Please enter an index for the integer array (0 - 4): ");
        index = Convert.ToInt32(Console.ReadLine());

        // Display the integer at that index on the screen
        if (index >= 0 && index < intArray.Length)
        {
            Console.WriteLine($"Selected integer: {intArray[index]}");
        }
        else
        {
            Console.WriteLine("This index doesn't exist in the integer array.");
        }

        // Create a list of strings
        List<string> strList = new List<string> { "Red", "Orange", "Yellow", "Green", "Blue" };

        // Ask the user to select an index of the list
        Console.WriteLine("Please enter an index for the string list (0 - 4): ");
        index = Convert.ToInt32(Console.ReadLine());

        // Display the content at that index on the screen
        if (index >= 0 && index < strList.Count)
        {
            Console.WriteLine($"Selected string: {strList[index]}");
        }
        else
        {
            Console.WriteLine("This index doesn't exist in the string list.");
        }
    }
}
