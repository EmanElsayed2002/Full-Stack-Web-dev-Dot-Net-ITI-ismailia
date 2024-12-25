using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DurationProgram
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

		public Duration(int _hours,int _minutes,int _seconds)
		{
			Hours= _hours;
			Minutes= _minutes;
			Seconds= _seconds;
		}

		public Duration(int _seconds)
		{
			
			Hours=_seconds/3600;
			_seconds = _seconds%3600;
			Minutes= _seconds/60;
			_seconds = _seconds%60;
			Seconds = _seconds;
			
		}

		public override string ToString()
		{
			
			return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
		}


		public static Duration operator +(Duration left, Duration right)
		{
			Duration result =new Duration(left.Hours+right.Hours,left.Minutes+right.Minutes,left.Seconds+right.Seconds);

			
			return result;

			
		}

		public static Duration operator +(Duration left, int right)
		{
			Duration d1 = new Duration(right);
			Duration result = new Duration(left.Hours + d1.Hours, left.Minutes + d1.Minutes, left.Seconds + d1.Seconds);


			return result;


		}


		public static Duration operator +(int left, Duration right)
		{
			Duration d1 = new Duration(left);
			Duration result = new Duration(d1.Hours + right.Hours, d1.Minutes + right.Minutes, d1.Seconds + right.Seconds);


			return result;


		}

		public static Duration operator ++(Duration left)
		{
			Duration result=new Duration(left.Hours,left.Minutes++,left.Seconds);
			return result ;
		}
		public static Duration operator --(Duration left)
		{
			Duration result = new Duration(left.Hours, left.Minutes--, left.Seconds);
			return result;
		}

		public static bool operator >(Duration left, Duration right)
		{
			if(left.Hours>right.Hours)
			{
				return true;
			}
			else if(left.Minutes>right.Minutes)
			{
				return true ;	
			}
			else if(left.Seconds>right.Seconds)
			{
				return true;
			}
			else
			{
				return false ;
			}
		}
		public static bool operator <(Duration left, Duration right)
		{
			if (left.Hours < right.Hours)
			{
				return true;
			}
			else if (left.Minutes < right.Minutes)
			{
				return true;
			}
			else if (left.Seconds < right.Seconds)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool operator >=(Duration left, Duration right)
		{
			if (left.Hours >= right.Hours)
			{
				return true;
			}
			else if (left.Minutes >= right.Minutes)
			{
				return true;
			}
			else if (left.Seconds >= right.Seconds)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		public static bool operator <=(Duration left, Duration right)
		{
			if (left.Hours <= right.Hours)
			{
				return true;
			}
			else if (left.Minutes <= right.Minutes)
			{
				return true;
			}
			else if (left.Seconds <= right.Seconds)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		public static explicit operator DateTime(Duration left)
		{
			DateTime result = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,
				left.Hours, left.Minutes, left.Seconds);
			
			return result;
		}


	}
}
