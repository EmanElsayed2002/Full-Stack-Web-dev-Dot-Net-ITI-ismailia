using System.Diagnostics;

Stopwatch s1 = new Stopwatch();
Stopwatch s2 = new Stopwatch();
Stopwatch s3 = new Stopwatch();

//first method

int num = 1;
int count = 0;
int result = 0;
s1.Start();
for (int i = 1; i < 99_999_999; i++)
{
	num = i;
	while (num > 0)
	{
		result = num % 10;
		if (result == 1)
		{
			count++;
		}
		num = num / 10;
	}

}
s1.Stop();
Console.WriteLine($"{count}");
Console.WriteLine(s1.Elapsed);
//////////////////////////////////////////////////////
//secont method
//Console.WriteLine("Enter num of nines");
//int num_Of_Nines = int.Parse(Console.ReadLine());
//int mult = 10;
//int result = 1;
//s2.Start();
//for (int i = 0; i < num_Of_Nines - 1; i++)
//{
//	result = result * 10 + mult;
//	mult = mult * 10;
//}
//s2.Stop();
//Console.WriteLine($"{result}");
//Console.WriteLine(s2.Elapsed);
///////////////////////////////////////////////////////////////
///
//third method
//string str;
//string[] words;
//int count = 0;
//s3.Start();
//for (int i = 1; i < 99_999_999; i++)
//{
//	str = i.ToString();
//	words = str.Split('1');
//	count += words.Length - 1;
//}
//s3.Stop();
//Console.WriteLine($"{count}");
//Console.WriteLine(s3.Elapsed);
