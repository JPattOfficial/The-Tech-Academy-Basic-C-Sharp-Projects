using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (object.ReferenceEquals(emp1, null))
            {
                return object.ReferenceEquals(emp2, null);
            }
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        public void Quit()
        {
            Console.WriteLine("The employee quit the job.");
        }
    }
}
