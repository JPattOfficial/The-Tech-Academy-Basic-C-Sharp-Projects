using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR_SUBMISSION_ASSIGNMENT
{
    public class Employee
    {
        public string Name { get; set; }

        // First constructor, it calls the second constructor
        public Employee(string name) : this(name, "N/A")
        {
        }

        // Second constructor
        public Employee(string name, string department)
        {
            Name = name;
            Console.WriteLine("Employee's name: " + Name);
            Console.WriteLine("Employee's department: " + department);
        }
    }
}