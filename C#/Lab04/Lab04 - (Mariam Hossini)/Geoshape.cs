using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth_day
{
     class Geoshape
    {
        protected double dimension_1;
        protected double dimension_2;
        public Geoshape()
        {
            dimension_1 = dimension_2 = 0;
        }
        public Geoshape(double _dimension) { 
            dimension_1=dimension_2 = _dimension;
        }
        public Geoshape(double _dimension1, double _dimension2)
        {
            dimension_1 = _dimension1 ;
            dimension_2 = _dimension2;
        }


    }
}
