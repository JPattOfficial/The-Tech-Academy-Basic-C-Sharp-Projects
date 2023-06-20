using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_SUBMISSION_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int constVar = 10;
            Console.WriteLine("Const Variable: " + constVar);
            Console.ReadLine();

            var someVar = "Hello World!";
            Console.WriteLine("Var Variable: " + someVar);

            Employee employee = new Employee("John Doe");

            Console.ReadLine();
        }
    }
}
