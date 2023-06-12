using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    public abstract class Person
    {
        public string firstName = "John";
        public string lastName = "Smith";

        public virtual void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}
