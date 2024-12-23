using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Rectangle : GeoShape
    {
        public Rectangle()
        {

        }

        public Rectangle(double _dim1, double _dim2) : base(_dim1, _dim2)
        {

        }

        public override double Area()
        {
            return dim1 * dim2;
        }
    }
}
