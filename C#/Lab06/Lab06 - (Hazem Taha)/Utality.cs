using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_07_CS
{
    // 7 0 0 0 5 6 7 5 0 7  5  3
    // 0 1 2 3 4 5 6 7 8 9  10 11 
    // 0           6
    // dis=6-0=6   6-1  5

    class Utality
    {
        public static int FindLongestDistacne(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            int maxDis = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    int temp = (i - dic[arr[i]]) - 1;
                    maxDis = Math.Max(maxDis, temp);
                }
                else
                {
                    dic[arr[i]] = i;
                }
            }
            return maxDis;
        }


        public static int ConountOccurrence(int num)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            int cnt = 0;

            for (int i = 0; i <= num; i++)
            {
                string temp = i.ToString();
                for (int k = 0; k < temp.Length; k++)
                {
                    if (temp[k] == '1')
                    {
                        cnt++;
                    }
                }
            }
            stw.Stop();

            Console.WriteLine($"With Time :{stw.ElapsedMilliseconds} ms ");

            return cnt;

        }
        public static long ConountOccurrenceV2(long n)
        {
           
            
            long count = 0;
            Stopwatch stw = new Stopwatch();
            stw.Start();

            for (long i = 0; i <= n;i++)
            {
                long num = i;

             
                while (num > 0)
                {
                    if (num % 10 == 1) 
                    {
                        count++;
                    }
                    num /= 10; 
                }
            }
            stw.Stop();
           
            Console.WriteLine($"With Time :{stw.ElapsedMilliseconds} ms ");
            return count;
            
        }

        public static long ConountOccurrenceV3(int num)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();

            long count = 0;
            long d = num.ToString().Length;
            long pw = (long)Math.Pow(10, d - 1);
            count = d *pw;
            stw.Stop();

            Console.WriteLine($"With Time :{stw.ElapsedMilliseconds} ms ");

            return count;
        }


    }

}
