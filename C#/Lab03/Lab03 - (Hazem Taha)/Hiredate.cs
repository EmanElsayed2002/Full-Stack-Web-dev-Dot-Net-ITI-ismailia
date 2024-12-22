using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__day4
{
     class Hiredate
    {
        int day;
        int month;
        int year;
        public Hiredate()
        {
            day = 0;
            month = 0;
            year = 0;
        }
        public Hiredate(int _day,int _monht, int _year)
        {
            day= _day;
            month= _monht;
            year= _year;
        }

        public int GetDay()
        {
            return day;
        }
        public int GetMonth()
        {
            return month;
        }
        public int GetYear()
        {
            return year;
        }

        public void SetDay(int _day)
        {
            day = _day;
        }
        public void SetMonth(int _month)
        {
            month = _month;
        }
        public void SetYear(int _year)
        {
            year = _year;
        }

    }
}
