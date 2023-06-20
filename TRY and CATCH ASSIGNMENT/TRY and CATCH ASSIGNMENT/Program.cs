using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();
                int age = int.Parse(input);

                if (age <= 0)
                {
                    throw new ArgumentException("Your age must be a positive number.");
                }

                int birthYear = DateTime.Now.Year - age;
                Console.WriteLine("You were born in the year: " + birthYear);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred. Please make sure you enter a valid number.");
            }

            Console.ReadLine();
        }
    }
}
