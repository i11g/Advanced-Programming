//ContainsKey(key) 

Dictionary<string,int> airplanes=new Dictionary<string, int>();

airplanes.Add ("Airbus 100", 150);
airplanes.Add ("Boing 150", 200);

if(airplanes.ContainsKey("Airbus 100"))
{
    Console.WriteLine($"Airbus 100 key exists");
}

//Contains Value 

Dictionary<string, int> magazines = new();

magazines.Add("Heavy Metal", 5);
magazines.Add("Corn", 1904);
Console.WriteLine(magazines.ContainsValue(5));
Console.WriteLine(magazines.ContainsValue(100));
