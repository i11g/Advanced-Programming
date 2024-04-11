int students=int.Parse(Console.ReadLine());

Dictionary<string,List<double>> studentsRegister=new Dictionary<string,List<double>>();
int countGrades = 0;

for (int i = 0; i < students; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());
    

    if(!studentsRegister.ContainsKey(student))
    {
        studentsRegister.Add(student, new List<double>());       
    }
      
    studentsRegister[student].Add(grade);            
    
}
var excellent=studentsRegister.Where(kvp =>kvp.Value.Average() >= 4.50);

foreach (KeyValuePair<string,List<double>> student in excellent)
{   
    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
}