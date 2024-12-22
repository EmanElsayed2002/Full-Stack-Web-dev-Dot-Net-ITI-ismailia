using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
     class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("ctor def of Child");
        }

        public override void show()
        {
            Console.WriteLine($"Child Show");
        }

    }
}
