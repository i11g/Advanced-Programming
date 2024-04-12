int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int rotations = int.Parse(Console.ReadLine());

while(rotations > 0)
{
	for (int i = 0; i <num.Length-1; i++)
	{
		int temporaryElement = num[num.Length-1-i];
		num[num.Length - 1-i] = num[num.Length - 1 - 1-i]; 
        num[num.Length - 1- 1- i]= temporaryElement;
	}
	rotations--;
}

Console.WriteLine(string.Join(", ", num));