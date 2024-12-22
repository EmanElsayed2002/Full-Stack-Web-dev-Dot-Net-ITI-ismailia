using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Day06
{
     class Parent
    {
        protected int x;
        protected int y;
        public Parent()
        {
            x = y = 0;
        }
        public Parent(int _x, int _y)
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

        public  void Show()
        {
            Console.WriteLine("Hello From Parent Class...");
        }
    }
    class Child : Parent
    {
        protected int z;

        public Child()
        {
            x = y = z = 0;
        }

        public Child(int _x, int _y, int _z)
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

        public  void Show()
        {
            Console.WriteLine("Hello from Child Class>>>");
        }
    }


    class subChild : Child
    {
        int k;
        public subChild()
        {
            x = y = z = k = 0;
        }
        public subChild(int _x, int _y, int _z, int _k)
        {
            x = _x;
            y = _y;
            z = _z;
            k = _k;
        }
        public int GetK()
        {
            return k;
        }
        public void SetY(int _k)
        {
            k = _k;
        }

        public  void Show()
        {
            Console.WriteLine("Hello From subChild");
        }

    }

}
