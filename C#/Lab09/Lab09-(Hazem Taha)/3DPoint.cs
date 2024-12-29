using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CS
{
    public class Point3D:IEquatable<Point3D>,IComparable,ICloneable
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

        public bool Equals(Point3D? obj)
        {
            Point3D left = obj as Point3D;
            return P1==left.P1&&P2==left.P2&& P3==left.P3;
        }

        public int CompareTo(object? obj)
        {
            Point3D left=obj as Point3D;
            if (P1 != left.P1)
                 return P1.CompareTo(left.P1);
            else return P2.CompareTo(left.P2);
        }

        public object Clone()
        {
            Point3D obj= new Point3D(P1,P2,P3);
            return obj;
        }

        public static implicit operator string(Point3D p)
        {
            return $" Point Coordinates:   ({p.P1},{p.P2},{p.P3})";
        }

        public static bool operator ==(Point3D left,Point3D right)
        {
            return right.P1 == left.P1 && right.P2 == left.P2 && right.P3 == left.P3;
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return right.P1 != left.P1 || right.P2 != left.P2 || right.P3 != left.P3;
        }

        public override int GetHashCode()
        {
            return P1 + P2 + P3;
        }



    }
}
