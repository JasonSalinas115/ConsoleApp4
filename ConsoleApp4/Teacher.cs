using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Teacher : Person
    {
        public string TeacherId { get; set; }

        Teacher (string teacherId, string firstName, string lastName)
        {
            teacherId = teacherId;
            FirstName = firstName;
            LastName = lastName;
        }
        public override void Talk()
        {
           Console.WriteLine("Im a teacher");
            Console.WriteLine($"My name is {FirstName} {LastName}, and teacher id is {TeacherId}");
        }
    }
}
