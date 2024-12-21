using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Department
	{
		private int deptId;
		private string deptName;

		public Department()
		{

		}

		public void SetDeptId(int _deptId)
		{
			deptId = _deptId;
		}
		public int GetDeptId()
		{
			return deptId;
		}
		public void SetDeptName(string _deptName)
		{
			deptName = _deptName;
		}
		public string GetDeptName()
		{
			return deptName;
		}

		public string print()
		{
			return deptName;
		}
	}
}
