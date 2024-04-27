static int ReadNumber(int start, int end)
{
    int number = int.Parse(Console.ReadLine());

    if (number<=start||number>=end)
    {
        throw new ArgumentException();
    }
    
    return number;
}


List<int> numbers = new List<int>();
int previousNumber = 1;

while(numbers.Count<=10)
{
    try
    {
        int result = ReadNumber(previousNumber, 100);
        numbers.Add(result);
        previousNumber = result;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number");
    }
    catch (ArgumentException)
    {
        Console.WriteLine($"Your number is not in range{previousNumber} - 100!");
    }
}
Console.WriteLine(string.Join(",",numbers));