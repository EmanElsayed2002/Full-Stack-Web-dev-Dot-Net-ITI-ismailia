using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public struct HiringDate
    {
        int day;
        int month;
        int year;

        public HiringDate()
        {
            Day = 0;
            Month = 0;
            Year = 0;
        }

        public HiringDate(int _day,int _month,int _year)
        {
            Day= _day;
            Month= _month;
            Year= _year;
        }
        public int Day { get { return day; } set { day = value; } }

        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }

        public override string ToString()
        {
            return $" {Day}-{Month}-{Year} ";
        }

    }
}
