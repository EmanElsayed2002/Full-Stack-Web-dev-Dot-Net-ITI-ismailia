using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Math_
{
    public static class MyMath
    {
        public static T Add<T>(T left, T right)where T : INumber<T> 
        {
            return left + right;
        }
        public static T Sub<T>(T left, T right)where T : INumber<T> 
        {
            return left - right;
        }
        public static T Mult<T>(T left, T right)where T : INumber<T> 
        {
            return left * right;
        }
        public static T Divide<T>(T left, T right)where T : INumber<T> 
        {
            return left / right;
        }
    }
}
