using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public static class MyMath
    {
        public static int X { get; set; }
        public static int Y { get; set; }


        public static int Add(int num1, int num2) 
        { 
        return num1 + num2;
        }
        
        public static int Subtract(int num1, int num2) 
        { 
        return num1 - num2;
        }
        public static long Multiply(long num1, long num2) 
        { 
        return num1 * num2;
        }
        public static long Divide(long num1, long num2) 
        { 
          if(num2==0)
            {
                Console.WriteLine("Can not divide by zero!!");
                return -1;
            }
          else
            {
                return num1 / num2;
            }

        }
        

    }
}
