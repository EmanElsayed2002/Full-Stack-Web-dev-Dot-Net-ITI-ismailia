using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Employee
    {
        int ssn;
        string name;
        int age;
        Department department = new Department();
        HireDate hireDate = new HireDate();

        //Department department;
        //HireDate hireDate;
        public Employee()
        {
            
        }

        public void SetSSN(int _ssn)
        {
            ssn = _ssn;
        }

        public int GetSNN()
        {
            return ssn;
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

        public void SetDepartment(Department _department)
        {
            department = _department;
        }

        public void SetHireDate(HireDate _hireDate)
        {
            hireDate = _hireDate;
        }

        public Department GetDepartment()
        {
            return department;
        }

        public HireDate GetHire()
        {
            return hireDate;
        }


        public Employee(int _ssn, string _name, int _age, Department _department, HireDate _hireDate)
        {
            ssn = _ssn;
            name = _name;
            age = _age;
            department = _department;
            hireDate = _hireDate;
        }





        public Employee(int _ssn, string _name, int _age, int _deptId, string _deptName, int _day, int _month, int _year)
        {

            ssn = _ssn;
            name = _name;
            age = _age;
            department.SetDeptId(_deptId);
            department.SetDeptName(_deptName);
            hireDate.SetDay(_day);
            hireDate.SetMonth(_month);
            hireDate.Setyear(_year);
        }


        public string Print()
        {
            return $" {ssn} : {name} : {age}\n {department.Print()}\n {hireDate.Print()}";
        }
        
    }
}
