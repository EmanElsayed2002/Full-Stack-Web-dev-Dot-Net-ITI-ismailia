using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class HireDate
	{
		private DateOnly date;

		public void SetDate(DateOnly _date)
		{
			date = _date;
		}
		public DateOnly GetDate()
		{
			return date;
		}

		public DateOnly print()
		{
			return date;
		}
	}
}

