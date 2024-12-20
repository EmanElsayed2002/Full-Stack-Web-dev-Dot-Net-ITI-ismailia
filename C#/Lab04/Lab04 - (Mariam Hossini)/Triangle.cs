using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth_day
{
    class Triangle: Geoshape
    {
        double  dim1;
        double dim2;
        public Triangle()
        {
            Console.WriteLine("Ctor of Triangle");
        }
        public Triangle(double _dim1, double _dim2) : base(_dim1, _dim2)
        {

        }
        public double TriangleArea()
        {
            return 0.5* dimension_1 * dimension_2;

        }
    }
}
