using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Circle : GeoShape
    {
        public Circle()
        {
            
        }

        public Circle(double _redius) : base(_redius)
        {
            
        }

        public double Area()
        {
            return Math.PI * dim1 * dim2;
        }
    }
}
