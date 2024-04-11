int numberOfCommands=int.Parse(Console.ReadLine());

Dictionary <string,string> register=new Dictionary<string,string>();
for (int i = 0; i < numberOfCommands; i++)
{
    List<string> commands = Console.ReadLine().Split(' ').ToList();

    if(commands.Contains("register"))
    {
        if (!register.ContainsKey(commands[1]))
        {
            register.Add(commands[1], commands[2]);
            Console.WriteLine($"{commands[1]} registered {commands[2]} successfully" );
        }
        else 
        {
            Console.WriteLine($"ERROR: already registered with plate number {register[commands[1]]}" );
        }
    }
    else
    {
        if (!register.ContainsKey(commands[1]))
        {
            Console.WriteLine($"ERROR: user {commands[1]} not found" );
        }
        else
        {
            register.Remove(commands[1]);
            Console.WriteLine($"{commands[1]} unregistered successfully");
        }


    }
}
foreach (var registered in register)
{
    Console.WriteLine($"{registered.Key} => {registered.Value}" );
}
