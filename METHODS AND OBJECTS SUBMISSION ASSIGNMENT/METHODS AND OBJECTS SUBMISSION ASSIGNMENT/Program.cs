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
        }
    }
}
