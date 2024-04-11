using System.Text.RegularExpressions;

string phonesNumbers=Console.ReadLine();

Regex pattern = new(@"\+359(?<seperators>[ -])2\k<seperators>[0-9]{3}\k<seperators>[0-9]{4}\b");
MatchCollection matches = pattern.Matches(phonesNumbers);

Console.WriteLine(string.Join(", ", matches.Select(x => x.Value.Trim()).ToArray()));