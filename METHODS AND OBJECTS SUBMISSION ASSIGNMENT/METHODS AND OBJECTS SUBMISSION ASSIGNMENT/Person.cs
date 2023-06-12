using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    public class Person
    {
        public string firstName = "John";
        public string lastName = "Smith";

        public void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
        }
    }
}
