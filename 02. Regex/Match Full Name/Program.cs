using System.Text.RegularExpressions;
using System.Text;

string names=Console.ReadLine();

Regex pattern = new(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

MatchCollection matches = pattern.Matches(names);

StringBuilder sb = new();

foreach (Match match in matches)
{
    sb.Append($"{match.Value} ");
}

sb.ToString().Trim();

Console.WriteLine(sb);