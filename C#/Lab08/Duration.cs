using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration()
        {
            Console.WriteLine("Duration Initialized :)");
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int Total)
        {
            Hours = Total / (60 * 60);
            Minutes = (Total % (60 * 60)) / 60;
            Seconds = (Total % 60);
        }


        public static Duration operator +(Duration d1, Duration d2)
        {
            int TotalDuration = d1.Hours * 60 * 60 + d2.Hours * 60 * 60;
            TotalDuration += d1.Minutes * 60 + d2.Minutes * 60;
            TotalDuration += d1.Seconds + d2.Seconds;
            return new Duration(TotalDuration);
        }

        public static Duration operator +(Duration d1, int d2)
        {
            Duration d = new Duration(d2);
            int TotalDuration = d1.Hours * 60 * 60 + d.Hours * 60 * 60;
            TotalDuration += d1.Minutes * 60 + d.Minutes * 60;
            TotalDuration += d1.Seconds + d.Seconds;
            return new Duration(TotalDuration);
        }

        public static Duration operator +(int d2, Duration d1)
        {
            Duration d = new Duration(d2);
            int TotalDuration = d1.Hours * 60 * 60 + d.Hours * 60 * 60;
            TotalDuration += d1.Minutes * 60 + d.Minutes * 60;
            TotalDuration += d1.Seconds + d.Seconds;
            return new Duration(TotalDuration);
        }

        public static Duration operator ++(Duration d)
        {
            int TotalDuration = d.Hours * 60 * 60;
            TotalDuration += d.Minutes * 60 + 1;
            TotalDuration += d.Seconds;
            return new Duration(TotalDuration);
        }

        public static Duration operator --(Duration d)
        {
            int TotalDuration = d.Hours * 60 * 60;
            TotalDuration += d.Minutes * 60 - 1;
            TotalDuration += d.Seconds;
            return new Duration(TotalDuration);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            int TotalDuration1 = d1.Hours * 60 * 60;
            TotalDuration1 += d1.Minutes * 60 + 1;
            TotalDuration1 += d1.Seconds;

            int TotalDuration2 = d2.Hours * 60 * 60;
            TotalDuration2 += d2.Minutes * 60 + 1;
            TotalDuration2 += d2.Seconds;

            return TotalDuration1 > TotalDuration2;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            int TotalDuration1 = d1.Hours * 60 * 60;
            TotalDuration1 += d1.Minutes * 60 + 1;
            TotalDuration1 += d1.Seconds;

            int TotalDuration2 = d2.Hours * 60 * 60;
            TotalDuration2 += d2.Minutes * 60 + 1;
            TotalDuration2 += d2.Seconds;

            return TotalDuration1 < TotalDuration2;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            int TotalDuration1 = d1.Hours * 60 * 60;
            TotalDuration1 += d1.Minutes * 60 + 1;
            TotalDuration1 += d1.Seconds;

            int TotalDuration2 = d2.Hours * 60 * 60;
            TotalDuration2 += d2.Minutes * 60 + 1;
            TotalDuration2 += d2.Seconds;

            return TotalDuration1 <= TotalDuration2;
        }


        public static implicit operator DateTime(Duration d)
        {
            return DateTime.MinValue.AddHours(d.Hours).AddMinutes(d.Minutes).AddSeconds(d.Seconds);
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            int TotalDuration1 = d1.Hours * 60 * 60;
            TotalDuration1 += d1.Minutes * 60 + 1;
            TotalDuration1 += d1.Seconds;

            int TotalDuration2 = d2.Hours * 60 * 60;
            TotalDuration2 += d2.Minutes * 60 + 1;
            TotalDuration2 += d2.Seconds;

            return TotalDuration1 >= TotalDuration2;
        }

        public override string ToString()
        {

            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds:{Seconds}";
        }
    }

}
