string text = "abc";

string repeated = "";

for (int i = 0; i < text.Length; i++)
{
    repeated += text;
}
Console.WriteLine(repeated);

//Seaarching text

//Contains - chechks wheter one string contain another

string text1 = "I alove fruits";

Console.WriteLine(text1.Contains("fruits"));
Console.WriteLine(text1.Contains("bababa"));

//Substring 
//Substring(int stsrindex, int length) 
string text2 ="bbbggg";
string sub = text2.Substring(2,3); //от индекс 2 вземи три стринга
Console.WriteLine(sub);
//Substring (int startindex) 
string text3 = "iiivvv";
string sub1= text3.Substring(3); //от индекс 3 вземи всичко до края
Console.WriteLine(sub1);                              
