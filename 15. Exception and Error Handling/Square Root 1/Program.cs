try
{
    int num = int.Parse(Console.ReadLine());

    if (num < 0)
    {
        throw new ArgumentException();
    }

    double sqrt = Math.Sqrt(num);

    Console.WriteLine(sqrt);
}
catch (ArgumentException)
{
    Console.WriteLine("Invalid Number.");
}
catch (FormatException)
{
    Console.WriteLine("Invalid Format");
}
finally
{
    Console.WriteLine("Goodbye.");
}