using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Fifth_Lab
{
    abstract class GeoShape
    {
        protected double dim1;
        protected double dim2;

        public void SetDim1(double _dim1) { dim1 = _dim1; }
        public void SetDim2(double _dim2) { dim2 = _dim2; }
        public double GetDim1() { return dim1; }
        public double GetDim2() { return dim2; }

        public GeoShape()
        {
            dim1 = 0;
            dim2 = 0;
        }
        public GeoShape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }
        public abstract double CalculateArea();
    }
    class Circle : GeoShape
    {
        public Circle() : base()
        {

        }
        public Circle(double _dim1, double _dim2) : base(_dim1, _dim2)
        {

        }
        public override double CalculateArea() { return Math.PI * dim1 * dim2; }

    }
    class Rectangle : GeoShape
    {
        public Rectangle() : base()
        {

        }
        public Rectangle(double _dim1, double _dim2) : base(_dim1, _dim2)
        {

        }
        public override double CalculateArea() { return dim1 * dim2; }

    }
    class Triangle : GeoShape
    {
        public Triangle() : base()
        {

        }
        public Triangle(double _dim1, double _dim2) : base(_dim1, _dim2)
        {

        }
        public override double CalculateArea() { return 0.5 * dim1 * dim2; }
    }
    class Square : GeoShape
    {
        public Square() : base()
        {

        }
        public Square(double _dim1, double _dim2) : base(_dim1, _dim2)
        {

        }
        public override double CalculateArea() { return dim1 * dim2; }
    }


    class GetAreas
    {
        //version1 
        public static double SumOfAreasV1(Square[] _squares, Rectangle[] _rectangles)
        {
            double sum = 0;
            for (int i = 0; i < _squares.Length; i++)
            {
                sum += _squares[i].CalculateArea();

            }
            for (int i = 0; i < _rectangles.Length; i++)
            {
                sum += _rectangles[i].CalculateArea();

            }
            return sum;
        }
        //version2
        public static double SumOfAreasV2(GeoShape[] _geoshapes)
        {
            double sum = 0;
            for (int i = 0; i < _geoshapes.Length; i++)
            {
                sum += _geoshapes[i].CalculateArea();
            }
            return sum;
        }
    }
}
