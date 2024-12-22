using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
     class Subclass : Child
    {
        public Subclass()
        {
            Console.WriteLine("ctor def of Subclass");
        }
        public override void show()
        {
            Console.WriteLine($"SubClass Show");
        }

    }
}
