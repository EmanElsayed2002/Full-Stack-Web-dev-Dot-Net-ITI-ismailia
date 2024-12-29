using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Duration_
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }
        public Duration(int seconds)
        {
            Hours = seconds / 3600;
            seconds %= 3600;
            Minutes = seconds / 60;
            seconds %= 60;
            Seconds = seconds;

        }
        public Duration(int hours, int minuts, int seconds) : this(tosec(hours, minuts, seconds))
        {

        }
        public override string ToString()
        {
            {
                if (Hours > 0)
                {
                    return $" {Hours} Hours : {Minutes} Minutes : {Seconds} Seconds ";
                }
                if (Minutes > 0)
                {
                    return $" {Minutes} Minutes : {Seconds} Seconds ";
                }
                return $" {Seconds} Seconds ";
            }
        }
        public static int tosec(int hours, int min, int sec)
        {
            return (hours * 3600) + (min * 60) + sec;
        }
        public static Duration operator +(Duration Left, Duration Right)
        {

            return new(Left.Hours + Right.Hours, Left.Minutes + Right.Minutes, Left.Seconds + Right.Seconds);

        }
        public static Duration operator +(Duration Left, int sec)
        {
            Duration Right = new(sec);
            return new(Left.Hours + Right.Hours, Left.Minutes + Right.Minutes, Left.Seconds + Right.Seconds);
        }
        public static Duration operator +(int sec, Duration Left)
        {
            Duration Right = new(sec);
            return new(Left.Hours + Right.Hours, Left.Minutes + Right.Minutes, Left.Seconds + Right.Seconds);
        }
        public static Duration operator ++(Duration Left)
        {
            return new(Left.Hours, Left.Minutes + 1, Left.Seconds);
        }
        public static Duration operator --(Duration Left)
        {
            return new(Left.Hours, Left.Minutes - 1, Left.Seconds);
        }
        public static bool operator >(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    if (right.Seconds == left.Seconds)
                    {
                        return false;
                    }
                }
            }
                return left.Hours > right.Hours && left.Minutes > right.Hours && left.Seconds > right.Seconds;


        }
        public static bool operator >=(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    if (right.Seconds == left.Seconds)
                    {
                        return true;
                    }
                }
            }
            return left.Hours > right.Hours && left.Minutes > right.Hours && left.Seconds > right.Seconds;


        }
        public static bool operator <(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    if (right.Seconds == left.Seconds)
                    {
                        return false;
                    }
                }
            }
                return left.Hours < right.Hours && left.Minutes < right.Hours && left.Seconds < right.Seconds;


        }
        public static bool operator <=(Duration left, Duration right)
        {
            if (left.Hours == right.Hours)
            {
                if (left.Minutes == right.Minutes)
                {
                    if (right.Seconds == left.Seconds)
                    {
                        return true;
                    }
                }
            }
            return left.Hours < right.Hours && left.Minutes < right.Hours && left.Seconds < right.Seconds;


        }
        public static explicit operator DateTime(Duration left)
        {
            
            DateTime result = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,left.Hours,left.Minutes,left.Seconds);
            
            return result;
        }
    }
}
