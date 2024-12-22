using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__day4
{
    class Department
    {
        int deptId;
        string deptName;
        public Department()
        {
            deptId = 0; 
            deptName = string.Empty;
        }
        public Department(int _deptId, string _deptName)
        {
            deptId = _deptId;
            deptName = _deptName;
        }

        public int GetDeptId()
        {
            return deptId;
        }
        public string GetDeptName()
        {
            return deptName;
        }
        public void SetDeptId(int _deptId) 
        {
            deptId = _deptId;
        }
        public void SetDeptName(string _deptName)
        {
            deptName = _deptName;
        }



    }
}
