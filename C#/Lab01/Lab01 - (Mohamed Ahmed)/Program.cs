using System.Security.Cryptography;

namespace C__Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///int[] arr = new int[10];
            ///int count = 0;
            ///Console.WriteLine("please enter 10 numbers: ");
            ///do 
            ///{
            ///    int result = int.Parse(Console.ReadLine());
            ///    arr[count] = result;
            ///    count++;
            ///}
            ///while (count < 10);


            #region Min&Max
            //int max = arr[0];
            //int min = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{

            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];
            //}


            //Console.WriteLine($"Max number is: {max}");
            //Console.WriteLine($"Min number is: {min}"); 
            #endregion

            #region Bubble Sort
            //int temp;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("**************");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"{arr[i]}");
            //} 
            #endregion

            #region Searching
            //bool flag = false;

            //Console.WriteLine("please enter your number: ");
            //int value = int.Parse(Console.ReadLine());
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == value)
            //    {
            //        Console.WriteLine($"found at index {i}");
            //        flag = true;
            //    }
            //}
            //if (!flag)
            //   Console.WriteLine("Not Found :("); 
            #endregion

            #region Matrix
            //int[,] arr = new int[3, 2];
            //int[,] arr2 = new int[2, 1];
            //int[,] arr3 = new int[3, 1];

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter number in index {i} {j}");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("****** arr2 ******");

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter number in index {i} {j}");
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < arr.GetLength(1); k++)
            //        {
            //            arr3[i, j] += arr[i, k] * arr2[k, j];
            //        }
            //    }
            //}

            //Console.WriteLine("Result: \n");

            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr3[i,j]}");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Bouns
            //int[,] arr = new int[3, 3];
            //int[,] arr2 = new int[3, 2];
            //int[,] arr3 = new int[3, 2];

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter number in index {i} {j}");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("****** arr2 ******");

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"enter number in index {i} {j}");
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < arr.GetLength(1); k++)
            //        {
            //            arr3[i, j] += arr[i, k] * arr2[k, j];
            //        }
            //    }
            //}

            //Console.WriteLine("Result: \n");

            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr3[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region avarage
            //int[,] arr = new int[3, 4];


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int k = 0; k < arr.GetLength(1); k++)
            //    {
            //        Console.WriteLine($"Enter number at index {i},{k}");
            //        arr[i, k] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arr.GetLength(1); i++)
            //{
            //    int sum = 0;
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        sum += arr[j, i];
            //    }
            //    double average = sum / (double)arr.GetLength(0);
            //    Console.WriteLine($"average of column {i + 1}: {average}");
            //} 
            #endregion


            #region BirthDate
            //int currentday = DateTime.Now.Day;
            //int currentmonth = DateTime.Now.Month;
            //int currentyear = DateTime.Now.Year;

            //int year, month, day;

            //do
            //{
            //    Console.WriteLine("enter your year");
            //    year = int.Parse(Console.ReadLine());
            //}
            //while (year < 1980 || year > 2024);

            //do
            //{
            //    Console.WriteLine("enter your month");
            //    month = int.Parse(Console.ReadLine());
            //}
            //while (month < 1 || month > 12);

            //do
            //{
            //    Console.WriteLine("enter your day");
            //    day = int.Parse(Console.ReadLine());
            //}
            //while (day < 1 || day > 31);

            //if (currentday < day)
            //{
            //    if (currentmonth == 1 || currentmonth == 3 || currentmonth == 5 || currentmonth == 7 || currentmonth == 8 || currentmonth == 10 || currentmonth == 12)
            //    {
            //        currentday += 31;
            //        currentday -= day;
            //    }
            //    else if (currentmonth == 2 || currentmonth == 6 || currentmonth == 9 || currentmonth == 11)
            //    {
            //        currentday += 30;
            //        currentday -= day;

            //    }
            //    else if (currentmonth == 2)
            //    {
            //        bool isLeapYear = (currentyear % 4 == 0 && (currentyear % 100 != 0 || currentyear % 400 == 0));

            //        currentday += isLeapYear ? 29 : 28;
            //    }
            //    currentmonth = currentmonth - 1;
            //}

            //if (currentmonth < month)
            //{
            //    currentmonth += 12;
            //    currentmonth  -= month;
            //    currentyear -= 1;
            //}

            //Console.WriteLine($"you're {currentyear - year}y  {currentmonth} months and {currentday} days");

            #endregion

            #region calc
            //string answer = "";
            //do
            //{
            //    Console.WriteLine("Enter number 1");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter number 2");
            //    int num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter operator from( + - / * % )");

            //    string op = Console.ReadLine();

            //    double result;
            //    switch(op)
            //    {
            //        case "+":
            //            result = num1 + num2;
            //            Console.WriteLine(result);
            //            break;
            //        case "-": 
            //            result = num1 - num2;
            //            Console.WriteLine(result);
            //            break;
            //        case "*":
            //            result = num1 * num2;
            //            Console.WriteLine(result);
            //            break;
            //        case "/":
            //            result = num1 / num2;
            //            Console.WriteLine(result);
            //            break;

            //        default:
            //            Console.WriteLine("invalid operator");
            //            continue;
            //    }

            //    Console.WriteLine("do you want to countinue y or n");
            //    answer = Console.ReadLine();


            //} while (answer == "y"); 
            #endregion

        }
    }
}
