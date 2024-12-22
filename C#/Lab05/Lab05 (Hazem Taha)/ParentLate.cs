using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day06
{
    class ParentLate
    {

        protected int x;
        protected int y;
        public ParentLate()
        {
            x = y = 0;
        }
        public ParentLate(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void SetX(int _x)
        {
            x = _x;
        }
        public void SetY(int _y) { y = _y; }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }

        public virtual void Show()
        {
            Console.WriteLine("Hello From Parent Class...");
        }
    }

    class ChildLate : ParentLate
    {
        protected int z;

        public ChildLate()
        {
            x = y = z = 0;
        }

        public ChildLate(int _x,int _y,int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public void SetZ(int _z)
        {
            z = _z;
        }
        public int GetZ()
        {
            return z;
        }

        public override void Show()
        {
            Console.WriteLine("Hello from Child Class>>>");
        }
    }


    class subChildLate : ChildLate
    {
        int k;
        public subChildLate()
        {
            x = y = z = k = 0;
        }
        public subChildLate(int _x, int _y, int _z,int _k)
        {
            x = _x;
            y = _y;
            z = _z;
            k = _k;
        }
        public int  GetK()
        {
            return k;
        }
        public void SetY(int _k)
        {
            k = _k;
        }

        public override void Show()
        {
            Console.WriteLine("Hello From subChild");
        }

    }
}
