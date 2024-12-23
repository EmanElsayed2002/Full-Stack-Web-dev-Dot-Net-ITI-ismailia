using System.Collections.Generic;
using System.Diagnostics;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region longest distance 

            ////            0  1  2  3  4  5  6  7  8  9  10 11
            //int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };


            //int longStep = 0;
            //int steps = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            if (steps > longStep)
            //                longStep = steps;
            //        }
            //        steps++;

            //    }
            //    steps = 0;
            //}

            //Console.WriteLine(longStep);
            #endregion


            #region Split

            ////string str = "this is a test";

            //Console.Write("Please Enter Some Words: ");
            //string str = Console.ReadLine();

            //string result = string.Join(" ", str.Split(" ").Reverse());

            //Console.WriteLine(result);
            #endregion



            #region Count the occurrence of 1


            //Console.Write("Enter Number: ");
            //int value = int.Parse(Console.ReadLine());


            //Stopwatch s1 = Stopwatch.StartNew();

            //int count = 0;
            //for (int i = 0; i < value; i++)
            //{
            //    int number = i;
            //    while (number > 0)
            //    {
            //        if (number % 10 == 1)
            //        {
            //            count++;
            //        }
            //        number /= 10;
            //    }
            //}

            //Console.WriteLine(count);

            //s1.Stop();
            //Console.WriteLine(s1);
            //Console.WriteLine();
            /////////////////////////////////////////////////////////

            //Stopwatch s2 = Stopwatch.StartNew();

            //int counter = 0;
            //for (int i = 1; i <= value; i++)
            //{
            //    string[] str = i.ToString().Split("1");
            //    counter += str.Length - 1;
            //}
            //Console.WriteLine(counter);

            //s2.Stop();
            //Console.WriteLine(s2);
            //Console.WriteLine();

            ///////////////////////////////////////////////////////

            //Stopwatch s3 = Stopwatch.StartNew();

            //// count = digits * 10 ^ (digits - 1)

            //int di = value.ToString().Length;

            //int totalCount = di * (int)Math.Pow(10, di - 1);

            //Console.WriteLine(totalCount);

            //s3.Stop();
            //Console.WriteLine(s3);





            #endregion
















        }
    }
}
