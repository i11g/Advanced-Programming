//Dictionaries are arrays indexed by keys
//Hold a set of pairs - key - value

//    KEY                      Value
//Jonh Smith         +359 88889 9990 0001

Dictionary<string,string> phonebook=new ();
phonebook.Add("I.G", "359 88988 000 778");
phonebook.Add("B.O", "359 88888 000 778");

//The Values can be taken with the key

string values = phonebook["I.G"];
Console.WriteLine(values);
//The keys are unique

phonebook["I.G"] = "0000 1111 000";
string values1 = phonebook["I.G"];
Console.WriteLine(values1);

var fruits = new Dictionary<string, double>();
fruits["banana"] = 2.30;
fruits["apple"] = 2.00;
fruits["orange"] = 1.50;

phonebook.Remove("B.O");
phonebook.ContainsKey("B.O");

//Sorted Dictionary

var fruits1 = new SortedDictionary<string, double>();
fruits1["kiwi"] = 4.50;
fruits1["orange"] = 2.50;
fruits1["banana"] = 2.20;

foreach (KeyValuePair<string,double> fruit in fruits1)
{
    Console.WriteLine($"{fruit.Key} {fruit.Value}");
}

Dictionary<string, double> fruits2 = new()
{
    {"kiwi", 3.20},
    {"apple",2.30 }

};