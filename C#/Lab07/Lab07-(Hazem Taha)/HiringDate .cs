using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Day08
{
    public struct HiringDate
    {
        int day;
        int month;
        int year;


        public int Day { get { return day; } set { day = value; } }

        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }

        public override string ToString()
        {
            return $" {Day}-{Month}-{Year} ";
        }

    }
}
