using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    
    class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            Console.WriteLine("Your 3D point Initailzed");
        }
        
        public Point3D(int x, int y, int z) : this()
        {
            X = x; Y = y; Z = z;
        }

         
        public override string ToString()
        {
            return $"{X}:{Y}:{Z}";
        }

        public static implicit operator string(Point3D p)
        {
            return p.ToString();
        }


    }
}
