string [] bannedWords = Console.ReadLine().Split(", ").ToArray();
string text = Console.ReadLine();


for (int i = 0; i < bannedWords.Length; i++)
{
       string replace = "";

        if (text.Contains(bannedWords[i]))
        {

            for (int j = 0; j < bannedWords[i].Length; j++)
            {
                replace += '*';
            }

        }
        text = text.Replace(bannedWords[i], replace);
    
}
Console.WriteLine(text);
  
    
    
