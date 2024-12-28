using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{
     class Duration
    {
        public int Hours { set; get; }
        public int Minutes { set; get; }
        public int Seconds { set; get; }


        public Duration() { 
            Hours = Minutes = Seconds = 0;
        }


        public Duration(int _seconds) {
            while (_seconds > 60) {
                
                while (_seconds >= 3600) {
                    Hours++;
                    _seconds -= 3600;
                }
                while (_seconds >= 60) {
                    Minutes++;
                    _seconds -= 60;
                }

            }
            Seconds = _seconds;
        }


        public Duration(int _hours, int _minutes , int _seconds) { 
            Hours= _hours;
            Minutes= _minutes;  
            Seconds= _seconds;
        }

        //+operator
        public static Duration operator +(Duration d1 , Duration d2) {
            
            Duration d = new Duration((d1.Hours+d2.Hours) * 3600 + (d1.Minutes+d2.Minutes) * 60 + d1.Seconds+d2.Seconds);
            return d;
        }

        //+operator
        public static Duration operator +(Duration d1, int _seconds)
        {
            
            Duration d = new Duration((d1.Hours) * 3600 + (d1.Minutes) * 60 + d1.Seconds+_seconds);
            return d;
        }

        //+operatir
        public static Duration operator +( int _seconds ,Duration d1)
        {

            Duration d = new Duration((d1.Hours) * 3600 + (d1.Minutes) * 60 + d1.Seconds + _seconds);
            return d;
        }

        //++operator
        public static Duration operator ++(Duration d1)
        {

            Duration d = new Duration((d1.Hours) * 3600 + (d1.Minutes  + 1) * 60 + d1.Seconds );
            return d;
        }

        public static Duration operator --(Duration d1)
        {

            Duration d = new Duration((d1.Hours) * 3600 + (d1.Minutes - 1) * 60 + d1.Seconds);
            return d;
        }

        public static bool operator >(Duration d1 , Duration d2)
        {
            bool test = false;
            int second1 = d1.Hours*3600+d1.Minutes*60+d1.Seconds;
            int second2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            if (second1 > second2) { test = true; }
            return test;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            bool test = false;
            int second1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int second2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            if (second1 < second2) { test = true; }
            return test;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            bool test = false;
            int second1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int second2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            if (second1 >= second2) { test = true; }
            return test;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            bool test = false;
            int second1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int second2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            if (second1 <= second2) { test = true; }
            return test;
        }
        public static explicit operator DateTime(Duration _d){
            DateTime d = new DateTime();
            d =  DateTime.Parse(d.ToString());
            return d;
        }
        public override string ToString()
        {
            return $"Hours : {Hours}, Minutes : {Minutes}, Seconds: {Seconds}";
        }
    }
}
