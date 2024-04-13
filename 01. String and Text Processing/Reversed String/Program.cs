string word = Console.ReadLine();

string reversed = string.Join("", word.ToCharArray().Reverse());

Console.WriteLine($"{word}={reversed}");

string reversed1=new string(word.ToCharArray().Reverse().ToArray());
Console.WriteLine(reversed1);

//indexOf()

string fruits = "banana, orange, kiwi";
int firstIndex = fruits.IndexOf("banana");
Console.WriteLine(firstIndex);

//LastIndexOf 

string vegetables = "tomato, cucumbers, spinach";
int last = vegetables.LastIndexOf("cucumber");
Console.WriteLine(last);