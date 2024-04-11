using System.Threading.Tasks.Dataflow;

List<int> numbers=Console.ReadLine().Split(" ").Select(int.Parse).ToList();

numbers.Sort();

Dictionary<int,int> result=new Dictionary<int,int>();
// var result=new SortedDictionary<int,int>();

foreach (int number in numbers)
{
    if (result.ContainsKey(number))
    {
        result[number]+=1;

    }
    else
    {
        result.Add(number,1);
        //result[number] = 1;
    }
}

foreach (var res in result)
{
    Console.WriteLine($"{res.Key} -> {res.Value}");
}

//foreach (KeyValuePair<int,int> re in result)
//{
//    Console.WriteLine($"{re.Key}-{result}");
//}

