using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Day08
{
    public struct Employee
    {
        int id;
        string name;
        decimal salary;
        HiringDate hiringDate;
        SecurityLevel securityLevel;
        Gender gender;
        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal Salary { get { return salary; } set { salary = value; } }
        public HiringDate HiringDate { get { return hiringDate; } set { hiringDate = value; } }
        public SecurityLevel SecurityLevel { get { return securityLevel; } set { securityLevel = value; } }
        public Gender Gender { get { return gender; } set { gender = value; } }

        public override string ToString()
        {
            return $"{ID}:{Name}:{Gender}:{Salary:C}:{HiringDate}:{SecurityLevel} ";
        }
    }
}
