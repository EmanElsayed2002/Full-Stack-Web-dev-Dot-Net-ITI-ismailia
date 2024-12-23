using System.Diagnostics;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            Stopwatch s3 = new Stopwatch();

            int num;
            Console.Write("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            //count the number of 1s

            #region FIRST METHOD    
            string number;
            int count = 0;
            s1.Start();
            for (int i = 0; i < num; i++)
            {
                number = Convert.ToString(i);
                for (int j = 0; j < number.Length; j++)
                {
                    if (number[j] == '1') { count++; }
                }
            }
            s1.Stop();
            Console.WriteLine(count);
            Console.WriteLine(s1.Elapsed);
            #endregion

            #region SECOND METHOD

            int count2 = 0;
            s2.Start();
            for (int i = 0; i < num; i++) {
                int number2 = i;
                while (number2 > 0)
                {
                    if (number2 % 10 == 1) {
                        count2++;
                    }
                    number2 /= 10;

                } 
            }
            Console.WriteLine(count2);
            Console.WriteLine(s2.Elapsed);
            #endregion  
        }
    }
}
