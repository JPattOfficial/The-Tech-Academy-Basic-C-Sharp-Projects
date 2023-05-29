using System;

class Program
{
    static void Main(string[] args)
    {
        // Print the initial greeting
        Console.WriteLine("The Tech Academy.");
        Console.WriteLine("Student Daily Report.");

        // Ask for the student's name
        Console.WriteLine("What is your name?");
        string studentName = Console.ReadLine();

        // Ask for the current course
        Console.WriteLine("What course are you on?");
        string currentCourse = Console.ReadLine();

        // Ask for the current page number
        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();

        // Ask if the student needs help
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
        bool needsHelp = bool.Parse(Console.ReadLine());

        // Ask for any positive experiences
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string positiveExperiences = Console.ReadLine();

        // Ask for other feedback
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        // Ask for the number of study hours today
        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();

        // Print the closing message
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.ReadLine();
    }
}