using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ttask1
{
    public struct Emplyee
    {

        int id;
        string name;
        double salary;
        HireDate hireDate;
        SecurityLevel securityLevel;
        Gender gender;

        //getters and setters
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name  =  value; }
            get { return name; }
        }
        public double Salary { 
            set { salary = value; }
            get { return salary; }
        }
        public HireDate HireDate
        {
            set { hireDate = value; }
            get { return hireDate; }
        }
        public Gender Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public SecurityLevel SecurityLevel
        {
            set { securityLevel = value; }
            get { return securityLevel; }
        }

        public Emplyee(int _id, string _name, double _salary,HireDate _hireDate,SecurityLevel _securityLevel, Gender _gender)
        {
            id= _id;
            name= _name; 
            salary= _salary; 
            hireDate= _hireDate;
            securityLevel=_securityLevel;
            gender= _gender;
        }
        public override string ToString() {
            return $"Emplyee name:{name}\nEmplyee ID:{this.Id}\n" +
                $"Emplyee salary:{salary:C}\n" +
                $"Emplyee gender:{gender}\n" +
                $"Emplyee hiredate :{hireDate.Day} - {hireDate.Month} - {hireDate.Year}\n"+
                $"Emplyee Security Level : {securityLevel}";
                
        }
    }
}
