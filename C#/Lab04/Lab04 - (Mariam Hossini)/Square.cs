using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth_day
{
     class Square: Geoshape
    {
        double dim1;
        double dim2;
        public Square()
        {
            Console.WriteLine("Ctor of  Square"); }
       
        public Square(double _dim):base(_dim)
        {
            
        }
        public double SuareArea()
        {
            return dimension_1 * dimension_2;

        }
       
    }
}
