using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5lab
{
    class Circle : Shape
    {
        public Circle()
        {
            
        }
        public Circle(double _radius) :base(_radius)
        {
            
        }
        public double area()
        {
            return Math.PI * diminsion1 * diminsion2;
        }
    }
}
