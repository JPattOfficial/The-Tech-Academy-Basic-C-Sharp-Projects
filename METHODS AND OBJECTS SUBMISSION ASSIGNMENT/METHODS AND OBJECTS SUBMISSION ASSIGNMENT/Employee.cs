using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    public class Employee : Person
    {
        public int id;

        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }
}
