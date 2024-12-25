using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public struct HireDate
    {
        int day;
        int month;
        int year;
        public int Day
        {
            set { day = value;}
            get { return day;}
        }

        public int Month {
            set { month = value;}
            get {  return month; }
        }

        public int Year
        {
            set { year = value; }
            get { return year;}
        }
        public HireDate(int _day , int _month, int _year)
        {
            day = _day;
            month = _month; 
            year = _year;   
        }

    }
}
