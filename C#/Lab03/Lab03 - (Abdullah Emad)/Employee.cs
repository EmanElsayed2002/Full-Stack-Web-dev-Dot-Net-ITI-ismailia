using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2;

namespace ConsoleApp2
{
	class Employee
	{
		private int id;
		private string name;
		private int age;
		private decimal salary;
		HireDate hireDate = new HireDate();
		Department department = new Department();



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
			salary = _salary;
		}

		public decimal GetSalary()
		{
			return salary;
		}
		public void SetHireDate(DateOnly _date)
		{
			hireDate.SetDate(_date);
		}

		public HireDate GetHireDate()
		{
			return hireDate;
		}

		public void SetDepartment(string _department)
		{
			department.SetDeptName(_department);
		}

		public Department GetDepartment()
		{
			return department;
		}

		public string print()
		{
			return $"{id}:{name}:{age}:{salary}:{hireDate.print()}:{department.print()}";
		}
	}
}
