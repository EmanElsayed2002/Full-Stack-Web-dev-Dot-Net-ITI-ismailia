Console.WriteLine("Enter a sentence");
string str = Console.ReadLine();
string[] words = str.Split(' ');
for (int i = words.Length - 1; i >= 0; i--)
{
	Console.Write($"{words[i]} ");

}
Console.WriteLine();
