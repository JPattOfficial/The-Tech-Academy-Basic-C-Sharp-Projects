using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a one-dimensional array of strings
            string[] array = { "Hello", "World", "I", "am", "a", "string" };

            // Ask the user to input some text
            Console.Write("Please input some text: ");
            string input = Console.ReadLine();

            // Iterate through each string in the array and add the user's input
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += input;
            }

            // Print each string in the array one at a time
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // An infinite loop
            while (true)
            {
                // Fix the infinite loop so that it will execute properly
                // Let's add a condition to break the loop
                Console.Write("Do you want to continue? (y/n): ");
                string response = Console.ReadLine();
                if (response.ToLower() != "y")
                {
                    break;
                }

                // Add a loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }

                // Add another loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    Console.WriteLine(array[i]);
                }

                // Exit the while loop after its first iteration
                break;
            }

            // Define a list of strings where each item in the list is unique
            List<string> list = new List<string> { "Apple", "Orange", "Banana", "Grape", "Strawberry", "Apple" };

            // Ask the user to input text to search for in the list
            Console.Write("Please input text to search for in the list: ");
            string searchInput = Console.ReadLine();

            // Initialize a flag to check if the input was found
            bool found = false;

            // Iterate through the list and display the index of the list item that contains matching text
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == searchInput)
                {
                    Console.WriteLine($"Found match at index: {i}");
                    found = true;
                }
            }

            // Check if the user input is not on the list
            if (!found)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            Console.ReadLine();

            // Create a HashSet to store seen items
            HashSet<string> seenItems = new HashSet<string>();

            // Create a foreach loop that evaluates each item in the list
            foreach (string item in list)
            {
                // Check if the item has already appeared in the list
                if (seenItems.Contains(item))
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    seenItems.Add(item);
                    Console.WriteLine($"{item} - this item is unique");
                }
                Console.ReadLine();
            }
        }
    }
}