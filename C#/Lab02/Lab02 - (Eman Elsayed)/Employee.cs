using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
     class Employee
    {
        private int Id;
        private string Name;
        private int age;
        private decimal salary;

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetID()
        {
            return Id;
        }

        public void SetName(string _name)
        {
            Name = _name;
        }

        public string GetName()
        {
            return Name;
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
            return $"Employee id is {Id} : Name is {Name} : age is {age} and salary is {salary} ";
        }

    }
}
