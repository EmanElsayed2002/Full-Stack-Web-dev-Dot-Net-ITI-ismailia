using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Complex
	{
		private int real;
		private int img;

		public Complex() 
		{
			real = 0;
			img = 0;
		}
		public Complex(int _real,int _img)
		{
			real = _real;
			img = _img;
		}
		public void SetReal(int _real)
		{
			real = _real;
		}
		public int GetReal() { return real; }
		public void SetImg(int _img) { img = _img; }
		public int GetImg() { return img; }

		public string Print()
		{
			if(real==0 && img==0)
			{
				return $"0";
			}
			else if(real==0 && img == 1)
			{
				return $"i";
			}
			else if(real == 0 && img == -1)
			{
				return $"-i";
			}
			else if(real==0)
			{
				return $"{img}i";
			}
			else if (real != 0 && img == 0)
			{
				return $"{real}";
			}
			else if (real != 0 && img == 1)
			{
				return $"{real} + i";
			}
			else if(real!=0 && img==-1)
			{
				return $"{real} - i";
			}
			else if(real != 0 && img >0)
			{
				return $"{real} + {img}i";
			}
			else if(real != 0 && img < 0)
			{
				return $"{real} - {img*-1}i";
			}

			return $"{real} + {img}i";

		}

		public Complex Add(Complex right)
		{
			Complex result = new Complex();
			result.real =real + right.real;
			result.img =img + right.img;
			return result;
		}
	}
}
