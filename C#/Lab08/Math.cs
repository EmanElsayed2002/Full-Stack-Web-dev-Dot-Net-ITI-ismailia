using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Math
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public Math()
        {
            Console.WriteLine("Math Class Initaialized :)");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                return int.MinValue;
            }
            return num1 / num2;
        }



    }
}
