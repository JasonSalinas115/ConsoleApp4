using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee : Person
    {
        // Auto-implemented property
        public string EmployeeID { get; set; }

        // Constructor 


        public override void Talk()
        {
            //Console.WriteLine("Im a employee");
        }
    }
}
