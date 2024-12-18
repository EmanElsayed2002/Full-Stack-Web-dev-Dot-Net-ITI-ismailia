using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5lab
{
   class Shape
    {
        protected double diminsion1;
        protected double diminsion2;
        
        protected void setDiminsion1(double _diminsion1)
        {
            diminsion1 = _diminsion1;
        }
        protected void setDiminsion2(double _diminsion2)
        {
            diminsion2 = _diminsion2;
        }
        protected double getDiminsion1()
        {
            return diminsion1;
        }
        protected double getDiminsion2()
        {
            return diminsion2;
        }
        protected Shape()
        {
            diminsion1 = 0;
            diminsion2 = 0;
        }
        protected Shape(double _diminision1 , double _diminision2)
        {
             diminsion1 = _diminision1;
            diminsion2 = _diminision2;
        }
        protected Shape(double _diminision)
        {
            diminsion1 = diminsion2 = _diminision;
        }
         
        
        

    }
}
