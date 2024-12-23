using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Child : Parent
    {
        protected int z;
        public void SetZ(int _z) { z = _z; }
        public int GetZ() { return z; }

        public Child()
        {

        }

        public Child(int _x, int _y, int _z) : base(_x, _y)
        {
            z = _z;
        }

        public new void Show1()
        {
            Console.WriteLine("Child");
        }

        public override void Show()
        {
            Console.WriteLine("Child");
        }
    }
}
