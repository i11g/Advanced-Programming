string[] words=Console.ReadLine().Split(' ').ToArray();

string concatanatedWords = string.Empty;

for (int i = 0; i <words.Length ; i++)
{
  for (int j = 0; j < words[i].Length; j++)
    {
        concatanatedWords += words[i];
    }
}

Console.WriteLine(concatanatedWords);