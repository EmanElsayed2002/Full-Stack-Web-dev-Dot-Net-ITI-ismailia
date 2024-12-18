using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day4lab
{
    class Employee
    {
        //attributes
        private int id;
        private string name;
        private int age;
        private decimal salary;
        private string gender;
        Department department;
        HireDate hireDate;

        // hire date composions , department association
        public Employee()
        {
            id = 0;
            name = string.Empty;
            age = 0;
            salary = 0;
            gender = string.Empty;
            department = null;
            hireDate = new HireDate();
        }
        public Employee(int id, string name, int age, decimal salary, string gender, Department department,int day , int month ,int year)
        {
            this.hireDate =new HireDate();
            this.id = id;
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.gender = gender;
            this.department = department;
            this.hireDate.setDay(day);
            this.hireDate.setMonth(month);
            this.hireDate.setYear(year);
        }


        #region //setter
        public void setId(int _id)
        {
            id = _id;
        }
        public void setName(string _name )
        {
            name = _name;
        }
        public void setAge(int _age)
        {
            age = _age;
        }
        public void setSalary(decimal _salary)
        {
                salary = _salary;
        }
        public void setGender(string _gender)
        {
            gender = _gender;
        }
        public void setDepartment(Department _department)
        {
            department = _department;
        }
        public void setHireDateday(int day)
        {
            hireDate.setDay(day);
        }
        public void setHireDatemonth(int month)
        {
            hireDate.setMonth(month);
        }
        public void setHireDateyear(int  year)
        {
            hireDate.setYear(year);
        }


        #endregion
        #region// getters
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public decimal  getSalary()
        {
            return salary;
        }
        public string getGender()
        {
            return gender;
        }
        public Department GetDepartment()
        {
            return department;
        }
        public HireDate getHiredate()
        {
            return hireDate;
        }
        #endregion
        private string validateDepartmentName()
        {
           return department.getName() != null? department.getName() : "not found"  ;
        }

        public string print()
        {
            return $"Id = {id} name = {name} age = {age} salary = {salary} gender = {gender} , Department = {validateDepartmentName()}, Hiredate = {hireDate.print()}";  
        }
    }
}
