using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth_day
{
     class Rectangle: Geoshape
    {
        double dim1;
        double dim2;
        public Rectangle()
        {
            Console.WriteLine("Ctor of Rectangle");
        }
        public Rectangle(double _dim1 , double _dim2):base(_dim1,_dim2)
        {
            
        }
        public double RectArea()
        {
            return dimension_1 * dimension_2;
        }
    }
}
