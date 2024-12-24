using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab09
{
    public class Employee
    {
        int id;
        string name;
        SecurityLevels securityLevel;
        decimal salary;
        Hiredate hiredate;
        Gender gender;
        public int _Id
        {
            get
            {
                return _Id;
            }
            set
            {
                id = value;
            }
        }
        public string _Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public SecurityLevels _SecureLevels
        {
            get
            {
                return securityLevel;
            }
            set
            {
                securityLevel = value;
            }
        }
        public decimal _Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public Hiredate _HireDAte
        {
            get
            {
                return hiredate;
            }
            set
            {
                hiredate = value;
            }
        }
        public Gender _Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public Employee()
        {
            id = 0;
            name = "";
            securityLevel = new SecurityLevels();
            salary = 0;
            gender = new Gender();
            hiredate = new Hiredate();
        }

        public void SetEmployeeHireDate(int day , int month ,int year )
        {
            hiredate = new Hiredate(day, month, year);
        }

        public override string ToString()
        {
            return $"ID: {id}\t:Name: {name}\t:SecurityLevels: {securityLevel}\t:Salary{salary:C}\t:Gender:{gender}\t:HireDate:{hiredate._day}/{hiredate._month}/{hiredate._year}";
        }
    }
}
