List<string> text=Console.ReadLine().Split(" ").ToList();

//Dictionary<string,int> words=new Dictionary<string,int>(); 

List<string> words = new List<string>();

foreach (string word in text.Where(x=>x.Length%2==0))
{
    if(words.Contains(word))
    {
        continue;
    }
    else
    { 
        words.Add(word);
    }
}

foreach (string word in words) { Console.WriteLine(word); }
//Console.WriteLine(string.Join(" ",words));
