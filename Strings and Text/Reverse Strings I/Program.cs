string command = Console.ReadLine();
string reversedCommand = "";

while (command != "end")
{
    reversedCommand=new string (command.ToCharArray().Reverse().ToArray());
    
    Console.WriteLine($"{command} = {reversedCommand}");

    command = Console.ReadLine();
}

reversedCommand=string.Join ("", reversedCommand.ToCharArray());
Console.WriteLine(reversedCommand);