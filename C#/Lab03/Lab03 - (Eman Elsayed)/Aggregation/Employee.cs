﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Employee
    {
        int ssn, age;
        string name;
        Department dept;
        HireDate hiredate;
        public Employee()
        {
            ssn = 0;
            age = 0;
            name = null;
            dept = null;
            hiredate = null;
            Console.WriteLine("Employee Constructor Created");
        }

        public Employee(int ssn, int age, string name)
        {
            this.ssn = ssn;
            this.age = age;
            this.name = name;
        }

        public void SetDept(Department _dept)
        {
            dept = _dept;
        }

        public void SetHireDate(HireDate _hiredate)
        {
            hiredate = _hiredate;
        }

        public string Print()
        {
            string deptInfo = dept != null ? dept.Print() : "No Department Info";
            string hireDateInfo = hiredate != null ? hiredate.Print() : "No Hire Date Info";
            return $"Employee Name: {name}, Age: {age}, SSN: {ssn}, {deptInfo}, Hire Date: {hireDateInfo}";
        }


    }
}
