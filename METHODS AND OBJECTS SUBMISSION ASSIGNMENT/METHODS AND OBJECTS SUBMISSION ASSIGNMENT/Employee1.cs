using System;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT
{
    public class Employee
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int Id { get; internal set; }

        internal void SayName()
        {
            throw new NotImplementedException();
        }
    }
}