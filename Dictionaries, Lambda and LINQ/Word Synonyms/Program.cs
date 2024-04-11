
int num = int.Parse(Console.ReadLine());

var synonyms = new Dictionary<string, List<string>>();

for (int i = 0; i <num; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if(synonyms.ContainsKey(word))
    {
        synonyms[word].Add(synonym);
    }
    else
    {
        synonyms.Add(word, new List<string> {synonym});
    }

}

foreach (KeyValuePair<string,List<string>> item in synonyms)
{
    Console.WriteLine($"{item.Key}-{string.Join(" ",item.Value)}");
}