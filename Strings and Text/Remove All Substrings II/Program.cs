string toBeremoved = Console.ReadLine();
string baseLine = Console.ReadLine();

int startIndex = baseLine.IndexOf(toBeremoved);

while(baseLine.Contains(toBeremoved))
{
    baseLine=baseLine.Remove(startIndex,toBeremoved.Length);
    startIndex = baseLine.IndexOf(toBeremoved);
}

Console.WriteLine(baseLine);