using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Student : Person
    {
        public string StudentId { get; set; }

        Student (string studentId, string firstName, string lastName)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
        }

        public override void Talk()
        {
           Console.WriteLine("I'm a student");
           Console.WriteLine($"My name is {FirstName} {LastName}, and student id is {StudentId}");
        }
    }
}
