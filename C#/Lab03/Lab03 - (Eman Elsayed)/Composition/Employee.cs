using System;
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
        HireDate hireDate;
        public Employee()
        {
            ssn = 0;
            age = 0;
            name = null;
            dept = new Department();
            hireDate = new HireDate();
            Console.WriteLine("Employee Constructor Created");
        }

        public Employee(int ssn, int age, string name , int deptId , string deptName, int hday , int hmonth , int hyear )
        {
            this.ssn = ssn;
            this.age = age;
            this.name = name;
            dept = new Department(deptId, deptName);
            hireDate = new HireDate(hday , hmonth , hyear);

        }

        public string Print()
        {
            return $"Employee Name: {name}, Age: {age}, SSN: {ssn},{dept.Print()} hireDate: {hireDate.Print()}";
        }


    }
}
