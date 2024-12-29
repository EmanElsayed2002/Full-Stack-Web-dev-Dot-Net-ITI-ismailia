using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Math_
{
    public class Mathv1
    {
        public T Add<T>(T left, T right) where T : INumber<T>
        {
            return left + right;
        }
        public T Sub<T>(T left, T right) where T : INumber<T>
        {
            return left - right;
        }
        public T Mult<T>(T left, T right) where T : INumber<T>
        {
            return left * right;
        }
        public  T Divide<T>(T left, T right) where T : INumber<T>
        {
            return left / right;
        }
    }
}
