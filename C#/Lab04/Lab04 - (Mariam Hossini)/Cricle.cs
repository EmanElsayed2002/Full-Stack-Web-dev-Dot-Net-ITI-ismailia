using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth_day
{
     class Cricle: Geoshape
    {
        double dim;
        public Cricle()
        {
        }

        public Cricle(int _dim):base( _dim)
        {

        }
        public double Circle_Area() { 
            return Math.PI *dim*dim;
        }

    }

}
