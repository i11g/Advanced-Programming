List <string> text=Console.ReadLine().Split(" ").ToList();

text = text.Select(x=>x.ToLower()).ToList();

Dictionary<string,int> result=new Dictionary<string,int>(); 

foreach (string line in text)
{
    if (result.ContainsKey(line))
    {
        result[line]++;
    }
    else
    {
        result.Add(line, 1);
    }
}

foreach (KeyValuePair<string,int> pair in result.Where(x=>x.Value%2!=0))
{
    Console.Write($"{pair.Key} ");
}