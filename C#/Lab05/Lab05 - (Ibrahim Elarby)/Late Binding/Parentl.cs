using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day6lab
{
    class Parentl
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
        public Parentl()
        {
            age = 0;
            name = string.Empty;
        }
        public Parentl(int _age , string _name)
        {
            age = _age;
            name = _name;
        }
        public virtual void showme()
        {
            Console.WriteLine("I am the father");
        }
    }
}
