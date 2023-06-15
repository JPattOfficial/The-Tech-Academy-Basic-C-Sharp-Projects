using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            Console.WriteLine("There are " + joes.Count + " employed here.");

            // Using lambda
            List<Employee> joesLambda = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("There are " + joesLambda + " Joes employeed here (Lambda)");

            // Employees with Id > 5
            List<Employee> idGreaterThanFive = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("There are " + idGreaterThanFive.Count + " employees named Joe here.");

            foreach (Employee joe in idGreaterThanFive)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }


            Console.ReadLine();
        }
    }
}
