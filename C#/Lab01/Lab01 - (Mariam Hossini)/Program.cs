using System.Diagnostics.CodeAnalysis;

namespace Try_second_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //done
            #region task1
            //int[] arr = new int[10] { 5, 4, 2, -1, -33, 55, 66, 77, 88, 100 };
            //int min = arr[0];
            //int max = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (min < arr[i])
            //    {
            //        min = arr[i];
            //    }
            //}
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (max > arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine($"Max number = {max}");
            //Console.WriteLine($"Min number = {min}");


            #endregion
            //done
            #region task2
            //int temp;
            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter # {i + 1}:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < (arr.Length); i++)
            //{
            //    for (int j = i + 1; j < (arr.Length); j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine(" =================================");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($" {i + 1} st# : {arr[i]}");
            //}
            #endregion
            //done
            #region task3
            //bool test = false;
            //int[] arr = new int[10];
            //int num;
            //int index = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"enter # {i + 1}:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //do
            //{
            //    test = false;
            //    Console.Write("enter a number to search: ");
            //    num = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (num == arr[i])
            //        {
            //            index = i + 1;
            //            test = true;
            //        }
            //    }
            //    if (test == true)
            //    {
            //        Console.WriteLine($"found at index {index}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"not found");
            //    }
            //}
            //while (test == false);
            #endregion
            //done
            #region task4
            //int[,] arr1 = new int[3, 2];
            //int[,] arr2 = new int[2, 1];
            //int[] arr = new int[3];
            //int sum = 0;
            //Console.WriteLine("Enter elements of first array:-");
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter arr[{i}][{j}]: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Enter elements of second array:-");
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter arr[{i}][{j}] : ");
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    sum = 0;
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        sum += arr1[i, j] * arr2[j, 0];
            //    }
            //    arr[i] = sum;
            //}
            //for (int j = 0; j < arr.Length; j++)
            //{
            //    Console.WriteLine($"{arr[j]}");
            //}

            #endregion

            //done
            #region task5
            //int[,] arr = new int[3,4];
            //double[] avg = new double[4];

            //double sum = 0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter arr[{i}][{j}]:");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        sum = 0;
            //        for (int k = 0; k < arr.GetLength(0); k++)
            //        {
            //            sum += arr[k, j];

            //        }
            //    avg[j] = sum/3;
            //}



            //for (int j = 0; j < avg.Length; j++)
            //{
            //    Console.WriteLine($"avg [{j+1}] = {avg[j]}");

            //}
            #endregion


            #region task6
            int d, y, m;
            int day, year, month;
            bool test = true;
            int current_day = DateTime.Now.Day;
            int current_month = DateTime.Now.Month;
            int current_year = DateTime.Now.Year;
            //year
            do
            {
                Console.Write("Please Enter your year from 1980->2023: ");
                y = int.Parse(Console.ReadLine());
            } while (y < 1980 || y > 2023);

            //month
            do
            {
                Console.Write("Please Enter your month: ");
                m = int.Parse(Console.ReadLine());
            }
            while (m < 1 || m > 12);

            //day

            do
            {
                Console.Write("Please Enter your day: ");
                d = int.Parse(Console.ReadLine());
                test = true;
                switch (m)
                {

                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (d < 1 || d > 31)
                        {
                            test = false;
                        };
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (d < 1 || d > 30)
                        {
                            test = false;
                        };
                        break;
                    case 2:
                        if (d < 1 || d > 29)
                        {
                            test = false;

                        };
                        if (y % 4 == 1 && (d == 29)) { test = false; }
                        break;
                }
            }
            while (test == false);
            day = current_day - d;
            if (day < 0)
            {
                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        day += 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        day += 30;
                        break;
                    case 2:

                        if (y % 4 == 1) { day += 28; }
                        else { day += 29; }
                        break;
                }
              current_month--;
            }
            month = current_month - m;
            if (month <= 0)
            {
                month += 12;
                current_year--;
            }
            year = current_year - y;
            Console.WriteLine($"you are {year} year , {month} month and {day} days");
            #endregion

            //done

            #region task7
            //double num1, num2, total =0;
            //char operat;
            //char choice;
            //do {
            //    Console.Write("Enter the first number: ");
            //    num1 = double.Parse(Console.ReadLine());
            //    Console.Write("Enter the second number: ");
            //    num2 = double.Parse(Console.ReadLine());
            //    Console.Write("Enter the third number: ");
            //    operat = char.Parse(Console.ReadLine());
            //    switch (operat) { 
            //        case'+':  total= num1+num2; break;
            //        case '-': total = num1 - num2; break;
            //        case '/': total = num1 / num2; break;
            //        case '*': total = num1 * num2; break;
            //        case '%': total = num1 % num2; break;
            //    }
            //    Console.WriteLine($"The result = {total}");
            //    Console.Write("Continue?(y or n)");
            //    choice= char.Parse(Console.ReadLine());
            //}
            //while (choice=='y' || choice=='Y');
            #endregion

        }
    }
}