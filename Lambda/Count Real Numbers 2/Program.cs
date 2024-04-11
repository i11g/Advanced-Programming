List<int> numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();  

Dictionary<int,int> result=new Dictionary<int,int>();

int numberOfOccurancies = 0; 

foreach (int number in numbers)
{
    if(result.ContainsKey(number))
    {
        result[number]++;
    }
    else
    {
        result.Add(number, 1);
    }
}
foreach (KeyValuePair<int,int> pair in result.OrderBy(x=>x.Key)) 
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}"); 
}
