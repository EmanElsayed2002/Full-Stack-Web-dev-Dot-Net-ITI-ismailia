#region Array of 10 elements
//int[] arr = new int[10];
//for(int i=0;i<arr.Length ;i++ )
//{
//	Console.WriteLine($"enter element number :{i + 1}");
//	arr[i] =int.Parse(Console.ReadLine());
//}
//int min = arr[0], max = arr[0];
//for(int i=0;i<arr.Length ;i++ )
//{
//	if (arr[i]<=min)
//	{
//		min = arr[i];
//	}
//}

//for (int i = 0; i < arr.Length; i++)
//{
//	if (arr[i]>=max)
//	{
//		max=arr[i];
//	}
//}
//Console.WriteLine($"the min num is {min}");
//Console.WriteLine($"the max num is {max}");


#endregion
#region sort ascending
//int[] arr = new int[10];
//for (int i = 0; i < arr.Length; i++)
//{
//	Console.WriteLine($"enter element number :{i + 1}");
//	arr[i] = int.Parse(Console.ReadLine());
//}
//int min_index=0;
//int min=arr[0];
//int temp = 0;
//for (int i = 0; i < arr.Length-1; i++)
//{
//	min = arr[i];
//	for (int j = i+1; j < arr.Length; j++)
//	{
//		if (arr[j] < min)
//		{
//			min_index = j;
//			min = arr[j];
//		}
//	}
//	temp =arr[i];
//	arr[i] = arr[min_index];
//	arr[min_index] = temp;

//}
//for(int i=0;i<arr.Length ;i++ )
//{
//	Console.Write($"{arr[i]}  ");
//}



#endregion
#region search number
//int[] arr = new int[10];
//for (int i = 0; i < arr.Length; i++)
//{
//	Console.WriteLine($"enter element number :{i + 1}");
//	arr[i] = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Enter a num to search for ");
//int num=int.Parse(Console.ReadLine());
//int index = 0;
//int flag = 0;
//for(int i = 0; i < arr.Length; i++)
//{
//	if (arr[i]==num)
//	{
//		index = i;
//		Console.WriteLine($"found at index {i+1}");
//		flag = 1;
//		break;
//	}
//}
//if(flag == 0)
//{
//	Console.WriteLine("Not found");
//}
#endregion
#region matrix
//int[,] arr1 = new int[3,3];
//int[,] arr2 = new int[3,2];
//int[,] arr3 = new int[3,2];
//Console.WriteLine("First Matrix 3x2");
//for (int i = 0; i < arr1.GetLength(0); i++)
//{
//	for (int j = 0; j < arr1.GetLength(1); j++)
//	{
//		Console.WriteLine($"enter element [{i},{j}]");
//		arr1[i, j] = int.Parse(Console.ReadLine());
//	}
//}

//Console.WriteLine("second Matrix 2x1");
//for (int i = 0; i < arr2.GetLength(0); i++)
//{
//	for (int j = 0; j < arr2.GetLength(1); j++)
//	{
//		Console.WriteLine($"enter element [{i},{j}]");
//		arr2[i, j] = int.Parse(Console.ReadLine());
//	}
//}

//for (int i = 0; i < 3; i++)
//{
//	for(int j=0;j<2 ; j++)
//	{
//		for (int k = 0; k < 3; k++)
//		{
//			arr3[i,j] += arr1[i, k] * arr2[k,j];
//		}
//	}


//}

//for (int i = 0; i < arr3.GetLength(0); i++)
//{
//	for(int j=0;j<arr3.GetLength(1) ; j++)
//	{
//		Console.Write($"{arr3[i,j]}  ");

//	}
//	Console.WriteLine();
//}

#endregion
#region AGE
//int currentday = DateTime.Now.Day;
//int currentmonth = DateTime.Now.Month;
//int currentyear = DateTime.Now.Year;
//int year, month, day;
//do
//{
//	Console.WriteLine("please enter your year");
//	year = int.Parse(Console.ReadLine());
//} while (year < 1980 || year > 2023);

//do
//{
//	Console.WriteLine("please enter your month");
//	month = int.Parse(Console.ReadLine());
//} while (month < 1 || month > 12);
//do
//{
//	Console.WriteLine("please enter your day");
//	day = int.Parse(Console.ReadLine());
//} while (day < 1 || day > 31);


//if (currentday < day)
//{
//	if (month == 2 && year % 4 == 0)
//	{
//		currentday = currentday + 29;
//		currentmonth--;
//	}
//	else if (month == 2 && year % 4 != 0)
//	{
//		currentday = currentday + 28;
//		currentmonth--;
//	}
//	else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
//	{
//		currentday = currentday + 31;
//		currentmonth--;
//	}
//	else if (month == 4 || month == 6 || month == 9 || month == 11)
//	{
//		currentday = currentday + 30;
//		currentmonth--;
//	}
//}

//if (currentmonth < month)
//{
//	currentmonth = currentmonth + 12;
//	currentyear--;
//}
//day = currentday - day;
//month = currentmonth - month;
//year = currentyear - year;
//Console.WriteLine($"your age is {year} years,{month} months,{day} days");


#endregion
#region simple calculator
//int num1, num2;
//char x, z;
//do
//{
//	Console.WriteLine("enter first num");
//	num1 = int.Parse(Console.ReadLine());
//	Console.WriteLine("enter second num");
//	num2 = int.Parse(Console.ReadLine());
//	Console.WriteLine("enter operator");
//	x = char.Parse(Console.ReadLine());
//	switch(x)
//	{
//		case '+':
//			Console.WriteLine($"{num1 + num2}");
//			break;
//		case '-':
//			Console.WriteLine($"{num1 - num2}");
//			break;
//		case '*':
//			Console.WriteLine($"{num1 * num2}");
//			break;
//		case '/':
//			Console.WriteLine($"{num1 / num2}");
//			break;
//		default:
//			break;
//	}

//	Console.WriteLine("do you want to continue y or n");
//	z = char.Parse(Console.ReadLine());
//} while (z == 'y');

#endregion
