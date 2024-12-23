Console.WriteLine("Enter size of array");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for (int i = 0; i < arr.Length; i++)
{
	Console.WriteLine($"Enter array element {i}");
	arr[i] = int.Parse(Console.ReadLine());
}
int count = 0;
int index = 0;
int distance = 0;
for (int i = 0; i < arr.Length; i++)
{
	for (int j = 1; j < arr.Length; j++)
	{
		if (arr[i] == arr[j])
		{
			index = j;
			distance = j - i - 1;
			if (count < distance)
			{
				count = distance;
			}
		}
	}
}
Console.WriteLine($"the longest distance is {count}");

