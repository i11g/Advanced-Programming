using System.Text;

static string Count(int[] nums)
{
    SortedDictionary<int, int> count = new();

    foreach (int num in nums)
    {
        count.TryAdd(num, 0);
        count[num]++;
    }

    StringBuilder sb = new();
    foreach (KeyValuePair<int, int> pair in count)
    {
        sb.AppendLine($"{pair.Key} -> {pair.Value}");
    }

    return sb.ToString().Trim();
}
int[] input = { 1, 2, 3, 6, 8, 2, 3, }; 
string result=Count(input);
Console.WriteLine(result);
