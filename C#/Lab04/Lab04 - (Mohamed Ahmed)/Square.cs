using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Square : GeoShape
    {
        public Square()
        {
            
        }

        public Square(double dim):base(dim)
        {
            
        }

        public double Area()
        {
            return dim1 * dim2;
        }

        public void SetDim1(double _dim1) { dim1 = dim2 = _dim1; }
        public void SetDim2(double _dim2) { dim2 = dim1 =  _dim2; }
        
    }
}
