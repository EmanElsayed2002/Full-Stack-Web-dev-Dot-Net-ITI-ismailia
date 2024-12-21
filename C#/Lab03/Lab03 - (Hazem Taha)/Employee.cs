using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__day4
{
    class Employee
    {
        int ssn;
        string name;
        int age;
        Department department;
        Hiredate hiredate;


        public Employee()
        {
            ssn= 0;
            name = null;
            age= 0;
            department = null;
            hiredate = null;
        }
        public Employee(int _ssn,string _name,int _age,int _deptId,string _deptName,int _day,int _month, int _year)
        {
            ssn= _ssn;
            name= _name;
            age= _age;
            department= new(_deptId,_deptName);
            hiredate= new(_day,_month,_year);
        }

        public Employee(int _ssn, string _name, int _age, Department _department, Hiredate _hiredate)
        {
            ssn = _ssn;
            name = _name;
            age = _age;
            department = _department;
            hiredate = _hiredate;
        }
        public int GetSsn()
        {
            return ssn;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public Department GetDepartment()
        {
            return department;
        }
        public Hiredate GetHiredate()
        {
            return hiredate;
        }

        public void SetSnn(int _ssn)
        {
            ssn=_ssn;
        }
        public void setName(string _name)
        {
            name= _name;
        }
        public void setAge(int _age)
        {
            age= _age;
        }
        

        public void SetDeparmentId(int _id)
        {
            department.SetDeptId(_id);
        }
        public void SetDpartmentName(string _name)
        {
            department.SetDeptName(_name);
        }
        public void SetHiredateDay(int _day)
        {
            hiredate.SetDay(_day);
        }
        public void SetHiredateMonth(int _month)
        {
            hiredate.SetMonth(_month);
        }
        public void SetHiredateYear(int _year)
        {
            hiredate.SetYear(_year);
        }
        public void SetDepartment(Department _department)
        {
            department = _department;
        }
        public void SetHiredate(Hiredate _hiredate)
        {
            hiredate = _hiredate;
        }
        public string Print()
        {
            return $"Name: {name},ssn: {ssn},age: {age},Department Name:{department.GetDeptName()}, Hiredate: {hiredate.GetDay()}/{hiredate.GetMonth()}/{hiredate.GetYear()}";
        }

    }
}
