using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static PARSING_ENUMS_SUBMISSION_ASSIGNMENT.Weekdays;

namespace PARSING_ENUMS_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Please enter the current day of the week: ");
        string userDay = Console.ReadLine();

        try
        {
            // Attempt to convert the user input into a day of the week
            eWeekdays day = (eWeekdays)Enum.Parse(typeof(eWeekdays), userDay, true);
            Console.WriteLine("The day of the week you entered is: " + day);
        }
        catch (Exception)
        {
            // If an error occurs (for instance, if the user didn't input a valid day of the week), print an error message
            Console.WriteLine("Please enter an actual day of the week.");
        }
        Console.ReadLine
    }
}
