using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MathProgram
{
	public class Math
	{
		private int num1;
		private int num2;

		private Math()
		{
			num1 = 0;
			num2 = 0;
		}

		public static int Add(int _num1,int _num2)
		{
			return _num1 + _num2;
		}
		public int Subtract(int _num1, int _num2)
		{
			return _num1 - _num2;
		}
		public int Multiply(int _num1, int _num2)
		{
			return _num1 * _num2;
		}
		public int Divide(int _num1, int _num2)
		{
			return _num1 / _num2;
		}

		static Math obj;
		public static Math createObject()
		{
			if (obj == null)
			{
				obj = new Math();
			}
			return obj;
		}
	}
}
