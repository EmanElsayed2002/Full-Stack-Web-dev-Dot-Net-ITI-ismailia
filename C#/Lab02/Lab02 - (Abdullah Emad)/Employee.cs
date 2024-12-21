using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Employee
	{
		private int id;
		private string name;
		private int age;
		private decimal salary;
		private HireDate date;
		private Department department;

		

		public void SetId(int _id)
		{
			id = _id;
		}
		public int GetId()
		{
			return id;
		}
		public void SetName(string _name)
		{
			name = _name;
		}
		public string GetName()
		{
			return name;
		}

		public void SetAge(int _age)
		{
			age = _age;
		}
		public int GetAge()
		{ 
			return age;
		}

		public void SetSalary(decimal _salary)
		{
			salary= _salary;
		}

		public decimal GetSalary()
		{
			return salary;
		}
		public void SetHireDate(HireDate _date)
		{
			date = _date;
		}

		public HireDate GetHireDate()
		{
			return date;
		}

		public void SetDepartment(Department _department)
		{
			department = _department;
		}

		public Department GetDepartment()
		{
			return department;
		}

		public string print()
		{
			return $"{id}:{name}:{age}:{salary}:{date.print()}:{department.print()}";
		}
	}
}
