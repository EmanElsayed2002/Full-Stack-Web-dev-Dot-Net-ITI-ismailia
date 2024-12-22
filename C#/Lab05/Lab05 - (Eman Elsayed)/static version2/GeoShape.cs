using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
     abstract class GeoShape
    {
        protected double dim1 , dim2;
        public GeoShape()
        {
            dim1 = dim2 = 0;
            Console.WriteLine("Ctor of def GeoShape");
        }

        public GeoShape(double _dim1 , double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
        public abstract double CArea();
    }

    class Circle: GeoShape
    {
        public Circle()
        {
            Console.WriteLine("Ctor def of Circle");
        }
        public Circle(double d): base(d , d)
        {
            
        }
        public override double  CArea()
        {
            return Math.PI * dim1 * dim1;
        }

    }

    class Traingle: GeoShape
    {


        public Traingle()
        {
            Console.WriteLine("Ctor of def Traingle");
        }

        public Traingle(int _base , int _height) : base(_base , _height)
        {
            
        }
        public override double CArea()
        {
            return 0.5 * dim1 * dim2;
        }
    }

    class Rectangle: GeoShape
    {

        public Rectangle()
        {
            Console.WriteLine("Ctor of def Rectangle"); 
        }

        public Rectangle(double h , double w): base(h , w)
        {
            
        }

        public override double CArea()
        {
            return  dim1 * dim2;
        }
    }

    class Squre : GeoShape
    {

        public Squre()
        {
            Console.WriteLine("Ctor def SQure");   
        }
        public Squre(double d): base(d , d) 
        {
            
        }
        public override double CArea()
        {
            return dim1 * dim2;
        }
    }
}
