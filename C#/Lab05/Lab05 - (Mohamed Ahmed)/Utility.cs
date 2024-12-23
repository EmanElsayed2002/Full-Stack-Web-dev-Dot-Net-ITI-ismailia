using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Utility
    {
        public static double SumOfAreas(Triangle[] triangles, Square[] squares)
        {
            double sum = 0.0;
            for (int i = 0; i < triangles.Length; i++)
            {
                sum += triangles[i].Area();
            }
            for (int i = 0; i < squares.Length; i++)
            {
                sum += squares[i].Area();
            }
            return sum;
        }

        public static double SumOfAreasWithLateBinding(GeoShape[] geoShapes)
        {
            double sum = 0.0;
            for (int i = 0; i < geoShapes.Length; i++)
            {
                sum += geoShapes[i].Area();
            }
            return sum;
        }
    }
}
