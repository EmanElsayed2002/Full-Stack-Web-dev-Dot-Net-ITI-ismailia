using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day4lab
{
    class HireDate
    {
        private int day;
        private int month;
        private int year;

        public HireDate()
        {
            this.day = 0;
            this.month = 0; 
            this.year = 0;
        }
        public HireDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void setDay(int day)
        {
            this.day = day;
        }
        public void setMonth(int month)
        {
            this.month = month;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public int getDay()
        {
            return day;
        }
        public int getMonth()
        {
            return month;
        }
        public int getYear()
        {
            return year;
        }
        public String print()
        {
            return $"{day} - {month} - {year}";
        }
    }
}
