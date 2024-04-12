string removeword = Console.ReadLine();
string text = Console.ReadLine();

int startIndexremoveword = text.IndexOf(removeword);

while (text.Contains(removeword))
{
    text= text.Remove(startIndexremoveword, removeword.Length);
    //text = text.Replace(removeword, "");
}

Console.WriteLine(text);

//Split

string text1 = "Hello, ha;ce of&nice.day";

string[] text2 = text1.Split(new char[] { ',', '&', '.',';' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(string.Join("|",text2)); 



