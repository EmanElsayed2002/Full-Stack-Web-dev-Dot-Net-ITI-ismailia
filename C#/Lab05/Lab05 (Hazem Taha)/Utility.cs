using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day06
{
     class Utility
    {
        public static double SumV1(Rectangel[] rec, Squer[] sqr, Trinagle[] trgl)
        {
            double sum = 0.0;
            for (int i = 0; i < rec.Length; i++)
            {
                sum += rec[i].CalculateArea();
            }
            for (int i = 0; i < sqr.Length; i++)
            {
                sum += sqr[i].CalculateArea();
            }
            for (int i = 0; i < trgl.Length; i++)
            {
                sum += trgl[i].CalculateArea();
            }
            return sum;
        }

        public static double SumV2(GeoShape[] Shapes)
        {
            double res = 0.0;
            for (int i = 0; i < Shapes.Length; i++)
            {
                res += Shapes[i].CalculateArea();
            }
            return res;
        }
    }


}
