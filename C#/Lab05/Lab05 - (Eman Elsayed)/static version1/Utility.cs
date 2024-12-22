using CS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_v1
{
     class Utility
    {
        public static double SumOfShapesV1(Circle[] circles, Rectangle[] rectangles, Traingle[] traingles)
        {
            double sum = 0;
            foreach (var circle in circles) sum += circle.CArea();
            foreach (var rectangle in rectangles) sum += rectangle.CArea();
            foreach (var traingle in traingles) sum += traingle.CArea();
            return sum;
        }
    }
}
