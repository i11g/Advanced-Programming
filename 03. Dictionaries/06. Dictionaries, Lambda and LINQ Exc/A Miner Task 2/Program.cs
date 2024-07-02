Dictionary<string,int> resources= new Dictionary<string,int>();

string command = Console.ReadLine(); 

while(command!="stop")
{
    int qunatity = int.Parse(Console.ReadLine());

    if (resources.ContainsKey(command))
    {
        resources[command]+= qunatity;
    }
    else
    {
        resources.Add(command, qunatity);
    }
    command = Console.ReadLine();
}
foreach (KeyValuePair<string,int> pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}