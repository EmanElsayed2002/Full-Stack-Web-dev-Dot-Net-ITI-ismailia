using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_day3lab
{
    class Employee
    {
        //attributes
        private int id;
        private string name;
        private int age;
        private decimal salary;
        private string gender;

        #region //setter
        public void setId(int _id)
        {
            id = _id;
        }public void setName(string _name )
        {
            name = _name;
        }public void setAge(int _age)
        {
            age = _age;
        }public void setSalary(decimal _salary)
        {
                salary = _salary;
        }public void setGender(string _gender)
        {
            gender = _gender;
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
        #endregion

        public void read()
        {
            
            Console.WriteLine("enter employee ID");
            setId(int.Parse(Console.ReadLine()));
            Console.WriteLine("enter employee Name");
            setName(Console.ReadLine());
            Console.WriteLine("enter employee Age");
            setAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("enter employee salary");
            setSalary(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("enter employee Gender");
            setGender(Console.ReadLine());
            
            
        }
        public string print()
        {
            return $"Id = {id} name = {name} age = {age} salary = {salary} gender = {gender}";  
        }
    }
}
