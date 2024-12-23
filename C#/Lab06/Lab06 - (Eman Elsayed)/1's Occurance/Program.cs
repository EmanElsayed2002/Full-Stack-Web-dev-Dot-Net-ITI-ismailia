using System.Diagnostics;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region using Casting String

            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.Write("Enter Your Number: ");
            int num = int.Parse(Console.ReadLine());
            int ans = 0;
            Console.Write(num);
            for (int i = 0; i <= num; i++)
            {
                string number = i.ToString();
                foreach (var ch in number)
                {
                    if (ch == '1')
                    {
                        ans++;
                       
                    }
                }
            }
            Console.WriteLine($"1's Occurance = {ans}");
            stopwatch.Stop();
            Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");
            #endregion


            #region Without Casting
            //Stopwatch stopwatch = Stopwatch.StartNew();
            //Console.Write("Enter Your Number Solution 2: ");
            //int num = int.Parse(Console.ReadLine());
            //int ans = 0;
            //for (int i = 0; i <= num; i++)
            //{
            //    ans += OccuranceOfOne(i);
            //}
            //Console.WriteLine($"1's Occurance = {ans}");
            //stopwatch.Stop();
            //Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");
            #endregion


            #region Mathmatical Solution 
            //Stopwatch stopwatch = Stopwatch.StartNew();
            //Console.Write("Enter Your Number Solution 3: ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //int factor = 1; 

            //while (n / factor > 0)
            //{
            //    int lowerNumbers = n % factor; 
            //    int currentDigit = (n / factor) % 10; 
            //    int higherNumbers = n / (factor * 10); 

            //    if (currentDigit == 0)
            //    {
            //        count += higherNumbers * factor;
            //    }
            //    else if (currentDigit == 1)
            //    {
            //        count += higherNumbers * factor + lowerNumbers + 1;
            //    }
            //    else
            //    {
            //        count += (higherNumbers + 1) * factor;
            //    }

            //    factor *= 10;
            //}
            //Console.WriteLine($"1's Occurance = {count}");
            //stopwatch.Stop();
            //Console.WriteLine($"Time Taken: {stopwatch.ElapsedMilliseconds} ms");
            #endregion
        }

        static int OccuranceOfOne(int num)
        {
            int cnt = 0;
            while(num > 0)
            {
                if (num % 10 == 1) cnt++;
                num = num / 10;
            }
            return cnt;
        }
    }
}
