using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Employee
    {
        private int id;
        private string name;
        private int age;
        private decimal salary;


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

        public string Print()
        {
            return ($"{id} : {name} : {age} : {salary}");
        }
    }
}
