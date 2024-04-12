string single=Console.ReadLine();

string letters = "";
string digits = "";
string others = "";

for (int i = 0; i < single.Length; i++)
{
    var ch = single[i];

    if (Char.IsDigit(ch))
    {
        digits+= ch;
    }
    else if (Char.IsLetter(ch))
    {
        letters += ch;
    }
    else
    {
        others+= ch ;
    }

}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(others);

