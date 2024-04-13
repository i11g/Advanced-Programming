using System.Text.RegularExpressions;

string dates = Console.ReadLine();

Regex pattern = new(@"\b(?<day>\d{2})(?<seperator>[-.\/])(?<month>[A-Z][a-z]+)\k<seperator>(?<year>\d{4})");

MatchCollection matches = pattern.Matches(dates);

foreach (Match match in matches)
{
    string day = match.Groups["day"].Value;
    string month = match.Groups["month"].Value;
    string year = match.Groups["year"].Value;

    Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
}


