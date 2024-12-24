using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
	public struct Employee
	{
		int id;
		string name;
		decimal salary;
		Gender g1;
		SecurityLevel securityLevel;
		HireDate hireDate = new HireDate();
		public Employee()
		{
			id = 0;
			name = string.Empty;
			salary = 0;
			

		}

		public int Id { get { return id; } set { id = value; } }
		public string Name { get { return name; } set { name = value; } }
		public decimal Salary { get { return salary; } set { salary = value; } }
		public Gender G1 { get { return g1; } set { g1 = value; } }
		public SecurityLevel SecurityLevel { get { return securityLevel; } set { securityLevel = value; } }
		


		public void SetDay(int _day)
		{
			hireDate.Day = _day;
		}
		public int GetDay()
		{
			return hireDate.Day;
		}
		public void SetMonth(int _month)
		{
			hireDate.Month = _month;
		}
		public int GetMonth(int _month)
		{
			return hireDate.Month;
		}
		public void SetYear(int _year)
		{
			hireDate.Year = _year;
		}
		public int GetYear()
		{
			return hireDate.Year;
		}

		public override string ToString()
		{
			return $"{id}:{name}:{salary:C}:{g1}:{securityLevel}";
		}
	}
}
