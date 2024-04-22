using System.Diagnostics;

namespace Students
{
    public class Program
    {
        private string firstName;

        private string lastName;

        private double grade;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }
        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public Program (string firstName, string lastName, double grade)

        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        
        static void Main(string[] args)
        {
            int numberOfStudents=int.Parse(Console.ReadLine());

            List<Students> students = new List<Students>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string [] info = Console.ReadLine().Split(' ').ToArray();
                string firstName = info[0];
                string lastName = info[1];
                double grade = double.Parse(info[2]);

                Students currentStudent = new Students(firstName,lastName,grade);

                students.Add(currentStudent);                
            }

            students=students.OrderByDescending(x=>x.Grade).ToList();
            foreach (Students student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }

    }

    
}