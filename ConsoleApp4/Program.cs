namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

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
        }
    }
}