using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    public struct Hiredate
    {
        int day, month, year;
        public int _day
        {
            get
            {
                return day;
            }
            set { day = value; }
        }
        public int _month
        {
            get
            {
                return month;
            }
            set { month = value; }
        }
        public int _year
        {
            get
            {
                return year;
            }
            set { year = value; }
        }
        public Hiredate()
        {
            day = month = year = 0;
        }
        public Hiredate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

    }
}
