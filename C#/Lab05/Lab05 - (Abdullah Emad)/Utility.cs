using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
	class Utility
	{
		public static double SumOfAreasV1(Rectangle[] rarr, Square[] sarr)
		{
			double sum = 0.0;
			for (int i = 0; i < rarr.Length; i++)
			{
				sum += rarr[i].CArea();
			}
			for (int i = 0; i < sarr.Length; i++)
			{
				sum += sarr[i].CArea();
			}
			
			return sum;
		}


		public static double SumOfAreasV2(Geoshape[] garr)
		{
			double sum = 0.0;
			for (int i = 0; i < garr.Length; i++)
			{
				sum += garr[i].CArea();
			}
			return sum;
		}
	}
}
