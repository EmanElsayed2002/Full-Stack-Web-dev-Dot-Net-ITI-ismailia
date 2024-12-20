using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourth_Try_Project
{
    internal class HireDate
    {
        int day;
        int month;
        int year;
        public HireDate() {
            Console.WriteLine("Hiredate Cotr");
        }
        public void SetDay(int _day) { day = _day; }
        public void SetMonth(int _month) { month = _month; }
        public void SetYear(int _year) { year = _year; }

        public int GetDay() { return day; }
        public int GetMonth() { return month; }
        public int GetYear() { return year; }
    }
}
