
static string[] ParseCsv(string csvData)
{
    if (string.IsNullOrEmpty(csvData))
    {
        return Array.Empty<string>();
    }

    return csvData.Trim().Split(',', StringSplitOptions.TrimEntries);
}

string input = "sofia,lllg%,           pleben";
string[] result= ParseCsv(input);
Console.WriteLine(string.Join(",",result));
