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
        public Employee()
        {
            ssn = 0;
            age = 0;
            name = null;
            Console.WriteLine("Employee Constructor Created");
        }

        public Employee(int ssn, int age, string name)
        {
            this.ssn = ssn;
            this.age = age;
            this.name = name;
        }

        public string Print(Department dept , HireDate hiredate)
        {
            return $"Employee Name: {name}\tAge: {age}\tSSN: {ssn}\t{dept.Print()}\thireDate: {hiredate.Print()}";
        }


    }
}
