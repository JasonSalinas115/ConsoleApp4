using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class PersonUtility // Method overloading class
    {
        public static void DescribePerson(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        public static void DescribePerson(string name, string gender)
        {
            DescribePerson(name); // Calls the method above
            Console.WriteLine($"Gender: {gender}");
        }

        public static void DescribePerson(string name, string gender, int age)
        {
            DescribePerson(name, gender); // calls the method above
            Console.WriteLine($"Age: {age}");
        }
    }
}
