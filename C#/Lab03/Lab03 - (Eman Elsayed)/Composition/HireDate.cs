using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
     class HireDate
    {
        int day , month , year;
        public HireDate()
        {
            day = 1;
            month = 1;
            year = 2024;
            Console.WriteLine("HireDate Constructor Created");
        }
        public HireDate(int d , int m , int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public string Print()
        {
            return $"{day} / {month} / {year}";
        }

    }
}
