static string GetRange(char a, char b)
{
    int chOne = Math.Min(a, b);
    int chTwo = Math.Max(a, b);

    string result = string.Empty;
    for (int i = chOne + 1; i < chTwo; i++)
    {
        result += $"{(char)i} ";
    }

    return result.Trim();
}

char ch1 = 'A';
char ch2 = 'B';
string result = GetRange('a', 'b');
Console.WriteLine(result);