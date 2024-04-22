Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

int number=int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    string word = Console.ReadLine();
    string synonym=Console.ReadLine();

    if(synonyms.ContainsKey(word))
    {
        synonyms[word].Add(synonym);
    }
    else
    {
        synonyms.Add(word, new List<string> {synonym});
    }
}
foreach (var word in synonyms)
{
    Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
}
