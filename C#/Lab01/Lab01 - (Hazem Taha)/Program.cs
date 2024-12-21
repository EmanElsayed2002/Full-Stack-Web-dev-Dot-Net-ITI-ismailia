using System.Diagnostics.Metrics;

namespace ProgrammingConceptLabDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region get min and max value
            //Console.WriteLine("array of 10 intergers and get min and max value:");
            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter # at index: {i}");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int maxValue =int.MinValue;
            //int minValue = int.MaxValue;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    if (arr[i] > maxValue)
            //        maxValue = arr[i];
            //    else if(arr[i] <minValue )
            //        minValue = arr[i];
            //}
            //Console.WriteLine($"Max Value is: {maxValue}");
            //Console.WriteLine($"Min Value is: {minValue}");
            //Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            #endregion

            #region sort it ascending
            //Console.WriteLine(" array of 10 integers and sort it ascending without any built in function:");
            //int[] arr2= new int[10];

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine($"Enter # at index: {i}");
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}


            //for (int i=0;i<arr2.Length;i++)
            //{
            //    for(int j=i+1;j<arr2.Length;j++)
            //    {
            //        int temp = 0;

            //        if(arr2[i] > arr2[j])
            //        {
            //            //swap
            //            temp=arr2[i];
            //            arr2[i]=arr2[j];
            //            arr2[j] = temp;
            //        }
            //    }
            //}

            //for(int i=0;i<arr2.Length;i++)
            //{
            //    Console.Write($" {arr2[i]}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("++++++++++++++++++++++++++++++++++");
            #endregion

            #region search number
            //Console.WriteLine("array of 10 integers and search number and get index:");

            //int[] arr = new int[10];
            //Console.WriteLine("Enter 10 Num:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter # in index {i}");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int numToSearch = 0;

            //Console.WriteLine("Enter Number to search");
            //numToSearch=int.Parse(Console.ReadLine());
            //bool NotFound = true;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    if (arr[i] == numToSearch)
            //    {
            //        Console.WriteLine($"found at index {i}");
            //        NotFound=true;
            //        break;
            //    }
            //}
            //if( NotFound ) Console.WriteLine("not found");

            #endregion

            #region matrix  3*2   *  2*1   =3*1

            //int[,] mat1 = new int[3, 2];
            //int[,] mat2 = new int[2, 1];
            //int[,] resArr = new int[3, 1];

            //Console.WriteLine("Enter First Matrix: ");

            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter # at index{i} , {j}");
            //        mat1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Enter Second Matrix: ");

            //for (int i = 0; i < mat2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter # at index{i} , {j}");
            //        mat2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}



            //for (int i = 0; i < resArr.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < resArr.GetLength(1); j++) 
            //    {
            //        for (int k = 0; k < mat1.GetLength(1); k++) 
            //        {
            //            resArr[i, j] += mat1[i, k] * mat2[k, j];
            //        }
            //    }
            //}


            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat1.GetLength(1); j++)
            //    {
            //        Console.Write($"{mat1[i, j]}     ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("*");
            //Console.WriteLine();
            //for (int i = 0; i < mat2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //        Console.Write($"{mat2[i, j]}     ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-----------------------");

            //for (int i = 0; i < resArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resArr.GetLength(1); j++)
            //    {
            //        Console.Write($"{resArr[i, j]}     ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region [BONUS]3*3   * 3*2    = 3*2

            //int[,] mat1 = new int[3, 3];
            //int[,] mat2 = new int[3, 2];
            //int[,] resArr = new int[3, 2];

            //Console.WriteLine($"Enter First Matrix:{mat1.GetLength(0)} * {mat2.GetLength(1)} :");

            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter # at index{i} , {j}");
            //        mat1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("--------------------------------------");

            //Console.WriteLine($"Enter First Matrix:{mat2.GetLength(0)} * {mat2.GetLength(1)} :");

            //for (int i = 0; i < mat2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter # at index{i} , {j}");
            //        mat2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

           


            //for (int i = 0; i < resArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resArr.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < mat2.GetLength(0); k++)
            //        {
            //            resArr[i, j] += mat1[i, k] * mat2[k, j];
                         
            //        }
            //    }
            //}


            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat1.GetLength(1); j++)
            //    {
            //        Console.Write($"{mat1[i, j]}     ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("*");
            //Console.WriteLine();
            //for (int i = 0; i < mat2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //        Console.Write($"{mat2[i, j]}     ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-----------------------");

            //for (int i = 0; i < resArr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < resArr.GetLength(1); j++)
            //    {
            //        Console.Write($"{resArr[i, j]}    ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region get average
            /// 5 - array of 3 rows,4 cols read and write   int[,]arr=new int[3,4];
            ///add get average of columns
            //int[,] arr = new int[3, 4];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter # at index{i} , {j}");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //int[] avrage = new int[4];
            //for (int i = 0; i < arr.GetLength(1); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        avrage[i] += arr[j, i];
            //    }
            //    avrage[i] = avrage[i] / arr.GetLength(0);
            //}
            //for(int i=0;i<avrage.Length ;i++)
            //{
            //    Console.WriteLine(avrage[i]);
            //}
            #endregion


            #region calculate your birth date

            //int year = 0;
            //int month = 0;
            //int day = 0;
            //do
            //{
            //    Console.WriteLine("plz enter your year from 1980->2023");
            //    year = int.Parse(Console.ReadLine());
            //} while (year < 1980 || year > 2024);
            //do
            //{
            //    Console.WriteLine("plz enter your month 1- 12: ");
            //    month = int.Parse(Console.ReadLine());
            //} while (month < 1 || month > 12);

            //int monthOnDays = 0;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        monthOnDays = 31;
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        monthOnDays = 30;
            //        break;
            //    case 2:
            //        if (year % 4 == 0)
            //        {
            //            monthOnDays = 29;
            //        }
            //        else
            //        {
            //            monthOnDays = 28;
            //        }
            //        break;
            //}

            //do
            //{
            //    Console.WriteLine($"plz enter your day 1-{monthOnDays}:");
            //    day = int.Parse(Console.ReadLine());
            //} while (day < 1 || day > monthOnDays);

            //DateTime today = DateTime.Now;
            //int currentYear = today.Year;
            //int currentMonth = today.Month;
            //int currentDay = today.Day;
            //int ageDays = currentDay - day;
            //if (ageDays < 0)
            //{

            //    int previousMonth = currentMonth - 1;
            //    if (previousMonth == 0)
            //    {
            //        previousMonth = 12;
            //        currentYear--;
            //    }
            //    int daysInPreviousMonth = 0;
            //    switch (month)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            daysInPreviousMonth = 31;
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            daysInPreviousMonth = 30;
            //            break;
            //        case 2:
            //            daysInPreviousMonth = (year % 4 == 0) ? 29 : 28;
            //            break;
            //    }

            //    ageDays += daysInPreviousMonth;
            //    currentMonth--;
            //}

            //int ageMonths = currentMonth - month;
            //if (ageMonths < 0)
            //{
            //    ageMonths += 12;
            //    currentYear--;
            //}
            //int ageYears = currentYear - year;

            //Console.WriteLine($"Your age is: {ageYears} years, {ageMonths} months, and {ageDays} days old.");

            #endregion

            #region simple calculator
            //int num1 = 0;
            //int num2 = 0;
            //Console.WriteLine($"Enter num1:");
            //num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter num2");
            //num2=int.Parse(Console.ReadLine());
            //char c;
            //Console.WriteLine("enter operator - + * /");
            //c=char.Parse(Console.ReadLine());

            //if(c=='-')
            //{
            //    Console.WriteLine($"{num1} - {num2} = {num1-num2}");
            //}
            //else if (c == '*')
            //{
            //    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

            //}
            //else if(c=='/')
            //{
            //    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

            //}
            //else if(c=='+')
            //{
            //    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

            //}

            #endregion

        }
    }
}
