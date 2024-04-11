string command = Console.ReadLine();

Dictionary<string, List<string>> companies = new();

while(command != "End")
{
    List<string> input=command.Split(' ').ToList();
    string name = input[0];
    string id = input[2];

    if (!companies.ContainsKey(name))
    {
        companies.Add(name,new List<string>());
        companies[name].Add(id); 
            
    }
    else
    {
        companies[input[0]].Add(input[2]);
    }
    command = Console.ReadLine();
    
}
foreach (var company in companies) 
{   
    Console.WriteLine(company.Key);
    foreach (var id in companies)
    {
        Console.WriteLine($"----{id}");
    }
}