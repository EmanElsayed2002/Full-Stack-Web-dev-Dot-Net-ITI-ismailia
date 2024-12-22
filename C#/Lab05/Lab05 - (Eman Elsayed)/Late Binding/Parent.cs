using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
     class Parent 
    {

        int age;
        string name;
        public Parent()
        {
            age = 0;
            name = "Eman";
            Console.WriteLine("ctor def of Parent");
        }

        public Parent(int _Age , string _name)
        {
            age = _Age;
            name = _name;   
        }


        public virtual void show()
        {
            Console.WriteLine($"Parent Show");
        }



    }
}
