using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public class Point3D
    {
        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }
        public Point3D()
        {
            P1 = 0;
            P2 = 0;
            P3 = 0;
        }
        public Point3D(int _p1,int _p2 ,int _p3)
        {
            P1 = _p1;
            P2= _p2;
            P3 = _p3;
        }
        public override string ToString()
        {
            return $" Point Coordinates:   ({P1},{P2},{P3})";
        }

        public static implicit operator string(Point3D p)
        {
            return $" Point Coordinates:   ({p.P1},{p.P2},{p.P3})";
        }

    }
}
