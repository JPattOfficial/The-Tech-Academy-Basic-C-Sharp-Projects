using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call and create new instance of the Employee method
            Employee sampleEmployee = new Employee() { FirstName = "Sample", LastName = "Student" };
            sampleEmployee.SayName();
            Console.ReadLine();

            IQuittable employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.Quit();

            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" };

            if (employee1 == employee2)
            {
                Console.WriteLine("The employees are the same.");
            }
            else
            {
                Console.WriteLine("The employees are not the same.");
            }
            Console.ReadLine();

            Employee<string> genericEmployee1 = new Employee<string>
            {
                Things = new List<string> { "C#", "HTML", "CSS", "JavaScript" }
            };

            Employee<int> genericEmployee2 = new Employee<int>
            {
                Things = new List<int> { 1, 2, 3, 4, 5 }
            };

            // Print all of the strings in the Things property of employee1
            foreach (string thing in genericEmployee1.Things)
            {
                Console.WriteLine(thing);
            }

            // Print all of the integers in the Things property of employee2
            foreach (int thing in genericEmployee2.Things)
            {
                Console.WriteLine(thing);
            }


            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 5, FirstName = "Jack", LastName = "Black" },
                new Employee { Id = 6, FirstName = "Jill", LastName = "White" },
                new Employee { Id = 7, FirstName = "Bob", LastName = "Marley" },
                new Employee { Id = 8, FirstName = "Tom", LastName = "Hanks" },
                new Employee { Id = 9, FirstName = "Sue", LastName = "Miller" },
                new Employee { Id = 10, FirstName = "Sara", LastName = "Jones" }
            };

            // Using foreach loop
            List<Employee> joes = new List<Employee>();
            foreach (var emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    joes.Add(emp);
                }
            }

            // Using lambda
            List<Employee> joesLambda = employees.Where(x => x.FirstName == "Joe").ToList();

            // Employees with Id > 5
            List<Employee> idGreaterThanFive = employees.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
