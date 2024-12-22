using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day6lab
{
    class Utililty
    {
        public static double sumofAreav1(Rectangler[] rec, Square[] seq)
        {
            double sum = 0;
            for (int i = 0; i < rec.Length; i++)
            {
                sum += rec[i].area();
            }
            for (int i = 0; i < seq.Length; i++)
            {
                sum += seq[i].area();
            }
            return sum;
        }
        public static double sumofAreav2(Shape[]shp)
        {
            double sum = 0;
            for (int i = 0; i < shp.Length; i++)
            {
                sum += shp[i].area();
            }
           
            return sum;
        }
    }
}
