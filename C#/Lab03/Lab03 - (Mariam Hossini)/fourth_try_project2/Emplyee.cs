using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourth_try_project2
{
    internal class Emplyee
    {
        //association
        string name;
        int id;
        int age;
        int salary;
        Department department;
        HireDate hireDate;

        public Emplyee()
        {
            hireDate = null;
            department = null;
            Console.WriteLine("Emplyee cotr");
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetId(int _id)
        {
            id = _id;
        }
        public void SetAge(int _age)
        {
            age = _age;
        }
        public void SetSalary(int _salary)
        {
            salary = _salary;
        }
        public void SetHireDate(HireDate _hiredate)
        {
            hireDate = _hiredate;
        }

        public void SetDepartment(Department _department)
        {
            department = _department;
        }

        public int GetAge() { return age; }
        public int GetSalary() { return salary; }
        public string GetName() { return name; }
        public int GetId() { return id; }
        public HireDate GetHireDate() { return hireDate; }
        public Department GetDepartment() { return department; }
    }
}
