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
            Employee sampleEmployee = new Employee();
            sampleEmployee.SayName();

            //Specifying variables of this inherited object
            sampleEmployee.firstName = "Sample";
            sampleEmployee.lastName = "Student";

            sampleEmployee.SayName();
            Console.ReadLine();

            IQuittable employee = new Employee();
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
        }
    }
}
