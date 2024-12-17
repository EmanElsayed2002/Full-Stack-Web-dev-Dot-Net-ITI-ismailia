using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
     class Department
    {
        int deptId;
        string deptName;
        public Department()
        {
            deptId = 0;
            deptName = null;
            Console.WriteLine("Department Constructor Created");
        }
        public Department(int id , string name)
        {
            deptId = id;
            deptName = name;
        }

        public string Print()
        {
            return $"DeptID:{deptId} : DeptName:{deptName}";
        }
    }
}
