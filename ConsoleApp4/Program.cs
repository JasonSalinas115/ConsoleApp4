namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>("1234", "Jason", "Salinas");

            // Replace this with userinput
            Student student = new Student();
            people.Add(student);

            Student student = new Student();
            student.FirstName = "Jason";
            student.LastName= "Salinas";
            people.Add(student); // Add to colletion

            Teacher teacher = new Teacher();
            teacher.FirstName = "jaun";
            teacher.LastName = "sal";
            people.Add(teacher);

            Employee employee = new Employee();
            employee.FirstName = "James";
            employee.LastName = "nas";
            people.Add(employee);

            Console.WriteLine($"Hello, {student.FirstName} {student.LastName}");
            student.Talk();

            Console.WriteLine($"Hello, {teacher.FirstName} {teacher.LastName}");
            teacher.Talk();

            Console.WriteLine($"Hello, {employee.FirstName} {employee.LastName}");
            employee.Talk();

            foreach ( Person person in people )
            {
                Console.WriteLine($"Hello, {person.FirstName} {person.LastName}");
                person.Talk();
            }

            PersonUtility.DescribePerson("Hason");
            PersonUtility.DescribePerson("Jason, Malw");
            PersonUtility.DescribePerson("Jason, Male, 20");

        }

        static void DescribeAnimal(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        static void DescribeAnimal(string name, string species)
        {

        }

        static void DescribeAnimal(string name, string species, int age)
        {

        }
    }
}