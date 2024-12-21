using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__day_5
{
    class GeoShape
    {
        protected double dim1;
        protected double dim2;
        public GeoShape()
        {
            dim1 = dim2 = 5;
        }
        public GeoShape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }

        public double GetDim1()
        {
            return dim1;
        }
        public double GetDim2()
        {
            return dim2;
        }
        public void SetDim1(double _dim1)
        {
            dim1 = _dim1;
        }

        public void SetDim2(double _dim2)
        {
            dim2 = _dim2;
        }

    }
    class Rectangel : GeoShape
    {
        public Rectangel()
        {

        }
        public Rectangel(double _dim1, double _dim2) : base(_dim1, _dim2)
        {
        }

        public double CalculateArea()
        {
            return dim1 * dim2;
        }
    }
    class Squer : Rectangel
    {
        public Squer()
        {

        }
        public Squer(double _dim) : base(_dim, _dim)
        {

        }
    }

    class Circel : GeoShape
    {
        public Circel()
        {

        }
        public Circel(double _dim) : base(_dim, _dim)
        {
        }

        public double CalcArea(double _dim)
        {
            return Math.PI * dim1 * dim1;
        }


    }

    class Trinagle:GeoShape
    {
        public Trinagle()
        {
            
        }
        public Trinagle(double _width,double _hight) : base(_width,_hight )
        {
            
        }

        public double CalculateArea()
        {
            return dim1 * dim2 *0.5;
        }
    }
}
