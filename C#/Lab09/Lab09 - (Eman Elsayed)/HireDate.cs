using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CS
{
    public struct HiringDate:IComparable
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
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
        

        public int CompareTo(object? obj )
        {
            HiringDate HD=(HiringDate)obj;
            if (HD.Year != Year)
                return Year.CompareTo(HD.Year);
            else if (HD.Month != Month)
                return Month.CompareTo(HD.Month);
            else 
                return Day.CompareTo(HD.Day); 
            
        }

        public override string ToString()
        {
            return $" {Day}-{Month}-{Year} ";
        }

    }
}
