using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day6lab
{
    class Parent
    {
        int age;
        string name;
        
        public void setAge(int _age)
        {
            age = _age;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public int getAge()
        {
            return age;
        }
        public string getName()
        {
            return name;
        }
        public Parent()
        {
            age = 0;
            name = string.Empty;
        }
        public Parent(int _age , string _name)
        {
            age = _age;
            name = _name;
        }
        public void showme()
        {
            Console.WriteLine("I am the father");
        }
    }
}
