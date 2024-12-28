using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_day9Lab
{
    public class Point3D
    {

        public double X {  get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point3D(double x , double  y ,double z)
        {
            X=x; Y=y; Z=z;
        }
        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
        public static implicit operator string(Point3D point)
        {
            return point.ToString() ;
        }

    }
}
