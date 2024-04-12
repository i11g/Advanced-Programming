//Strings are sequences of characters

string text = "Hello, C#";

//Strings are immutable. We can not change them.

string text1 = "Hello World";
text1 = text1 + "Upadated"; //създава се ново място нова памет на нашият компютър за промененият стринг

string line = "Sofia";

char ch = line[1];        //accessible by index
Console.WriteLine(ch);

//Converting string to and from a char array 

string value = "nine";
char[] chars=value.ToCharArray(); Console.WriteLine(string.Join(",",chars));

//Concatenating
string text2 = "Hello" + "," + "Stefan"; Console.WriteLine(text2);
text2 += "Ivan";
//Concat Mehtod
string first = "Hello";
string second = "Nana";
string  third =first + second; Console.WriteLine(third);
string third1=string.Concat(first,second); Console.WriteLine(third1);
//String Join

Console.WriteLine(string.Join("|",first,second,third1,third));