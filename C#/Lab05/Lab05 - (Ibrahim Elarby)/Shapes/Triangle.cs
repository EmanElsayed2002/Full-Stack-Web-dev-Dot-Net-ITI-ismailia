using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day6lab
{
    class Triangle : Shape
    {
        public Triangle()
        {

        }
        public Triangle(double dim1, double dim2) : base(dim1, dim2)
        {

        }
        public override double area()
        {
            return 0.5 * diminsion1 * diminsion2;
        }
    }
}
