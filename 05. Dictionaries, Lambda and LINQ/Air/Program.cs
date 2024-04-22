//Iterating Through a Dictionary 

using System.Collections.Generic;

Dictionary <string,double> fruits =new();

fruits.Add("banana", 2.20);
fruits.Add("apple", 2.50);
fruits.Add("orange", 3.00); 

foreach (var fruit in fruits)
{
    Console.WriteLine($"{fruit.Key}->{fruit.Value}");
}
