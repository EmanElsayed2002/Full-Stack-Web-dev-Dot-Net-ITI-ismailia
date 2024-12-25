using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }
        public Duration()
        {
        }
        public Duration(int _seconds)
        {
            Hours = _seconds / 3600;
            _seconds -=(Hours*3600);
            Minutes = _seconds / 60;
             _seconds -= (Minutes*60);
            Seconds = _seconds;
        }


         public static int  ToSec(Duration d)
        {
            int res=0;
            res += d.Hours * 3600;
            res+= d.Minutes * 60;
            res += d.Seconds;
            return res;
        }
        public static  Duration operator + (Duration left, Duration right)
            {
            int sec=0;
            sec += ToSec(left) + ToSec(right);
                
            Duration d = new Duration(sec);
            return d;
            }
        public static Duration operator +(Duration left, int n)
        {
            int sec = 0;
            sec += ToSec(left) + n;

            Duration d = new Duration(sec);
            return d;
        }
        public static Duration operator +( int n, Duration left)
        {
            int sec = 0;
            sec += ToSec(left) + n;

            Duration d = new Duration(sec);
            return d;
        }
        
        public static Duration operator ++ (Duration left)
        {
            int sec = 0;
            sec += ToSec(left) +60;

            Duration d = new Duration(sec);
            return d;
        }
        public static Duration operator --(Duration left)
        {
            int sec = 0;
            sec += ToSec(left) - 60;

            Duration d = new Duration(sec);
            return d;
        }
        public static bool operator <(Duration left,Duration right)
        {
            int sec = 0;
            if (ToSec(left) < ToSec(right))
                return true;
            else return false;
          
        }
        public static bool operator >(Duration left, Duration right)
        {
            int sec = 0;
            if (ToSec(left) > ToSec(right))
                return true;
            else return false;
        }


        public static bool operator <=(Duration left, Duration right)
        {
            int sec = 0;
            if (ToSec(left) <= ToSec(right))
                return true;
            else return false;

        }
        public static bool operator >=(Duration left, Duration right)
        {
            int sec = 0;
            if (ToSec(left) >= ToSec(right))
                return true;
            else return false;
        }

        public override string ToString()
        {
            if (Minutes == 0 && Hours == 0)
                return $" Seconds :{Seconds}";
            else if (Hours == 0)
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
            else
                return $"Hours: {Hours},Minutes :{Minutes}, Seconds :{Seconds}";
        }


        public static  explicit  operator DateTime(Duration d)
        {
            DateTime time = new DateTime();
            time.AddHours(d.Hours);
            time.AddMinutes(d.Minutes);
            time.AddSeconds(d.Seconds);
            return time;
        }


    }
}
