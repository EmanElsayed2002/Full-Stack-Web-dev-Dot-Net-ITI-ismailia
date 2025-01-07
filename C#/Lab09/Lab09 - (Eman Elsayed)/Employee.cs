using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CS
{
    public class Employee : IComparable
    {
        private int _id;
        private string _name;
        private decimal _salary;
        private HireDate _HireDate = new HireDate();
        private SecurityLevel _securityLevel;
        private Gender _gender;

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public HireDate HireDate
        {
            get => _HireDate;
            set => _HireDate = value;
        }

        public SecurityLevel SecurityLevel
        {
            get => _securityLevel;
            set => _securityLevel = value;
        }

        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public Employee()
        {
            ID = 0;
            Name = string.Empty;
            Salary = 0;
            Gender = Gender.Male;
            HireDate = new HireDate();
            SecurityLevel = SecurityLevel.Guest;
        }

        public Employee(int id, string name, decimal salary, HireDate HireDate, SecurityLevel securityLevel, Gender gender)
        {
            ID = id;
            Name = name;
            Salary = salary;
            HireDate = HireDate;
            SecurityLevel = securityLevel;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"{ID}: {Name}: {Gender}: {Salary:C}: {HireDate}: {SecurityLevel}";
        }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;
            return HireDate.CompareTo(other.HireDate);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Employee other)
            {
                return ID == other.ID && Name == other.Name && Salary == other.Salary && HireDate.Equals(other.HireDate) && SecurityLevel == other.SecurityLevel && Gender == other.Gender;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Name, Salary, HireDate, SecurityLevel, Gender);
        }
    }
}
