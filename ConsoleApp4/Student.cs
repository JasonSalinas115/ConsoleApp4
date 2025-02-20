using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Student : Person
    {
        public override void Talk()
        {
            Console.WriteLine("I'm a student");
        }
    }
}
