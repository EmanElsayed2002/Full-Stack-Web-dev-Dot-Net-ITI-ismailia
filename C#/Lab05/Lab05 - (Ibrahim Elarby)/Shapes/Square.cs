using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day6lab
{
    class Square : Shape
    {
        public Square()
        {

        }
        public Square(double dim) : base(dim)
        {

        }
        public override double area()
        {
            return diminsion1 * diminsion2;
        }
    }
}
