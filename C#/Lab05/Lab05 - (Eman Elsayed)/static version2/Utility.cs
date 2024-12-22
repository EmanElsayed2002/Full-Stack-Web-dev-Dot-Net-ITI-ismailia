using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_v2
{
     class Utility
    {
        public static double SumOfShapesV2(GeoShape[] shapes)
        {
            double sum = 0;
            foreach (var shape in shapes) sum += shape.CArea();
            return sum;
        }
    }
}
