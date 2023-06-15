using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    public class Employee<T> : Person, IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<T> Things { get; set; }

        public static bool operator ==(Employee<T> emp1, Employee<T> emp2)
        {
            if (object.ReferenceEquals(emp1, null))
            {
                return object.ReferenceEquals(emp2, null);
            }
            return emp1?.Id == emp2?.Id;
        }

        public static bool operator !=(Employee<T> emp1, Employee<T> emp2)
        {
            return !(emp1 == emp2);
        }

        public override void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        public void Quit()
        {
            Console.WriteLine("The employee quit the job.");
        }
    }
}