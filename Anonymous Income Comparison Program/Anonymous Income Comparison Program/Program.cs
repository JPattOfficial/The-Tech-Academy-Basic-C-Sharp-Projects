using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine("Person 1, enter your hourly rate of pay: ");
        string p1Rate = Console.ReadLine();
        Console.WriteLine("Now enter your average hours worked a week: ");
        string p1hours = Console.ReadLine();
        bool per1Rate = float.TryParse(p1Rate, out float num1);
        bool per1Hours = float.TryParse(p1hours, out float num2);

        float pay1 = num1 * num2;
        float pay11 = pay1 * 52; // There are 52 weeks in a year
        Console.WriteLine("Yearly Salary: " + pay11);
        Console.ReadLine();

        Console.WriteLine("Person 2, enter your hourly rate of pay: ");
        string p2Rate = Console.ReadLine();
        Console.WriteLine("Now enter your average hours worked a week: ");
        string p2hours = Console.ReadLine();
        bool per2Rate = float.TryParse(p2Rate, out float num3);
        bool per2Hours = float.TryParse(p2hours, out float num4);

        float pay2 = num3 * num4;
        float pay22 = pay2 * 52; // There are 52 weeks in a year
        Console.WriteLine("Yearly Salary: " + pay22);
        Console.ReadLine();

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool topPay = pay11 > pay22;
        Console.ReadLine();

        if (topPay)
        {
            Console.WriteLine("Good job! Person 1 makes more than Person 2!");
        }
        else
        {
            Console.WriteLine("Person 2 earned more income. Good job Person 2!");
        }

        Console.ReadLine();
    }
}