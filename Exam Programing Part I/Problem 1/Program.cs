int numberOfStudents = int.Parse(Console.ReadLine());

double average = 0;
double sum = 0;
for (int i = 0; i < numberOfStudents; i++)
{
    double grade = double.Parse(Console.ReadLine());
    sum += grade;
}
average = sum / numberOfStudents*1.00;
Console.WriteLine($"{average:f2}");