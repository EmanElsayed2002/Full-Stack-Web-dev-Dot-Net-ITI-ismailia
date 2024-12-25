using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
	public class Point3D
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
		public Point3D(int _x,int _y,int _z)
		{
			X= _x;
			Y= _y;
			Z= _z;
		}
		public override string ToString()
		{
			return $"Point Coordinates:   ({X}, {Y}, {Z})";
		}
		public static explicit operator string(Point3D left)
		{
			return left.ToString();
		}
	}
}
