using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__day3
{
    class Employee
    {
        
        private int id;
        private string name;
        private int age;
        private decimal salary;

        public int GetId()
        {
            return id;
        }
        public void SetId(int _id)
        {
            id=_id;
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
            if (_salary > 5000 && _salary < 10_000)
            { salary = _salary; }
            else
            {
                salary = 5000;
            }
        }
        public decimal GetSalary()
        {
            return salary;
        }

        public string Print()
        {
            return $"{id}:{name}:{age}:{salary}";
        }

    }
}
