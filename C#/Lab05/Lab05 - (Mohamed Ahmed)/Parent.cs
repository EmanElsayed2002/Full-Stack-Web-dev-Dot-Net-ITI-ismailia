using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Parent
    {
        protected int x;
        protected int y;

        public void SetX(int _x) { x = _x; }
        public void SetY(int _y) {  y = _y; }
        public int getX() { return x; }
        public int getY() { return y; }

        public Parent()
        {
            
        }
        public Parent(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Show1()
        {
            Console.WriteLine("Parent");
        }

        public virtual void Show()
        {
            Console.WriteLine("Parent");
        }
    }

   
    
}
