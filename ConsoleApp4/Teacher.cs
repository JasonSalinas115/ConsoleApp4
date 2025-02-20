using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Teacher : Person
    {
        public override void Talk()
        {
            Console.WriteLine("Im a teacher");
        }
    }
}
