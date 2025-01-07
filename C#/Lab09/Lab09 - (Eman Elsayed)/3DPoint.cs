using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CS
{
    public class Point3D : IComparable<Point3D>, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point3D point)
            {
                return X == point.X && Y == point.Y && Z == point.Z;
            }
            return false;
        }

        public int CompareTo(Point3D? other)
        {
            if (other == null) return 1;

            int result = X.CompareTo(other.X);
            if (result != 0) return result;

            result = Y.CompareTo(other.Y);
            if (result != 0) return result;

            return Z.CompareTo(other.Z);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        public static implicit operator string(Point3D point)
        {
            return point.ToString();
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Point3D left, Point3D right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
    }
}
