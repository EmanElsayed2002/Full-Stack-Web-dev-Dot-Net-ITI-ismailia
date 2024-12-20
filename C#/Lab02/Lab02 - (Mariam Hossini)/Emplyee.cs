using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_third
{
    class Emplyee
    {
        string name;
        int id;
        int age;
        int salary;
        public void SetName(string _name) {
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

        public int GetAge() { return age; }
        public int GetSalary() { return salary; }
        public string GetName() { return name; }
        public int GetId() { return id; }

    }
}
