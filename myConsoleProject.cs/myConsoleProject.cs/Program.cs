using System;

namespace myConsoleProject.cs
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
                Console.WriteLine("Hello, " + name + "!");
                Console.Read();
        }
    }
}
