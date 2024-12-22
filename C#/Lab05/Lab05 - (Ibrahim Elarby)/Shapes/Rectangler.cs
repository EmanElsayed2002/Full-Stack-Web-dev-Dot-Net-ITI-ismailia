using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day6lab
{
    class Rectangler : Shape
    {
        public Rectangler()
        {

        }
        public Rectangler(double dim1, double dim2) : base(dim1, dim2)
        {

        }
        public override double area()
        {
            return diminsion1 * diminsion2;
        }

    }
}
