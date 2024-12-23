using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class SubChild : Child
    {
        protected int a;
        public void SetA(int _a) { a = _a; }
        public int GetA() { return a; }

        public SubChild()
        {

        }

        public new void Show1()
        {
            Console.WriteLine("SubChild");
        }
        public override void Show()
        {
            Console.WriteLine("SubChild");
        }
    }
}
