namespace Students
{   
    public class Students
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
        public Students(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        
    }

    public class Program
    {    
        static void Main(string[] args)
        {
            string command = Console.ReadLine(); 
            
            List<Students> students = new List<Students>();

            while(command != "end")
            {
                string[] information = command.Split(" ");
                string firstName = information[0];
                string secondName = information[1];
                int age = int.Parse(information[2]);
                string homeTown = information[3]; 

                Students currentStudent = new Students(firstName,secondName,age, homeTown);

                students.Add(currentStudent);

                command = Console.ReadLine();
            }

            string newCommand = Console.ReadLine();

            var  filteredList = students.Where(x => x.HomeTown == newCommand).ToList();

            foreach (var item in filteredList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }
        }
    }
}
