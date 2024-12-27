using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class _3DPoint
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint()
        {
            X = 0;
            Y = 0;
            Z = 0;
            Console.WriteLine("Your constructor is initialized ");
        }
        public _3DPoint(int p) {
            X = Y = Z =p;
        }

        public _3DPoint(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }


        public  override string ToString() {
            return $"Point Coordinates: ({X} , {Y}, {Z})";

        }

        public static explicit operator string(_3DPoint point)
        {
            return point.ToString();
        }
    }
}
