List<string> words = Console.ReadLine().Split(' ').ToList();


Dictionary<string, int> occurrences = new();

foreach (string word in words)
{   
    string toLower=word.ToLower();
    if(occurrences.ContainsKey(toLower)) 
    {
        occurrences[toLower]++;
    }
    else
    {
        occurrences.Add(toLower, 1);
    }
}

foreach (var item in occurrences)
{
    if(item.Value%2!=0)
    {
        Console.Write($"{item.Key} ");
    }
}