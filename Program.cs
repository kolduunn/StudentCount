namespace StudentCount
{

    internal class Program
    {

        static dynamic RemoveStudent(int id, List<Student> students)
        {
            var remainingStudents = from s in students
                                    where s.Id != id
                                    select s;

            return remainingStudents;
        }

        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "John"),
                new Student(2, "Alice"),
                new Student(3, "Bob")
            };

            var remainingStudents = RemoveStudent(2, students);

            int count = 0;

            foreach (var student in remainingStudents)
            {
                count++;
            }
            Console.WriteLine($"RemainingStudents: {count}");
        }
    }
}
