using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day4lab
{
    class Complex
    {
        //attributes
        private double real;
        private double imginary;
        private char opreator ;

        public Complex()
        {
            real = 0;
            imginary = 0;
            opreator = '+';
        }
        public Complex(double _real, double _imginary)
        {
            this.real = _real;
            this.imginary = _imginary;

        }

        //setters
        public void setReal(double real)
        {
            this.real = real;
        }
        public void setImaginary(double imginary)
        {
            this.imginary = imginary;
        }
        public double getReal()
        {
            return real;
        }
        public double getImaginary()
        {
            return imginary;
        }

        public void read()
        {
            Console.WriteLine("enter the real part");
            setReal(double.Parse(Console.ReadLine()));
            Console.WriteLine("enter the imaginary part");
            setImaginary(double.Parse(Console.ReadLine()));
        }

        public Complex add(Complex c )
        {
            Complex result = new Complex();
            result.real = real + c.real;
            result.imginary = imginary + c.imginary;
            return result;
        }
        public Complex substract(Complex c )
        {
            Complex result = new Complex();
            result.real = real - c.real;
            result.imginary = imginary - c.imginary;
            return result;
        } 
        public Complex multiply(Complex c )
        {
            Complex result = new Complex();
            result.real = (real * c.real) - (imginary * c.imginary); ;  
            result.imginary = (real * c.imginary) + (imginary * c.real); ;
            return result;
        }
        private double multiplyMirror(Complex c)
        {
            Complex result = new Complex();
            result.real = (c.real * c.real) + (c.imginary * c.imginary);;
            
            return result.real;
        }
        private Complex mirror(Complex c )
        {
            Complex result = new Complex();
            result.real = c.real;
            result.imginary = (-1)*c.imginary ;
            return result;
        }
        public Complex division(Complex c)
        {
            Complex result = new Complex();
            
            result = multiply(c.mirror(c));
            result.real /= multiplyMirror(c);
            result.imginary /= multiplyMirror(c);
            return result;
        }
        public string print()
        {    
            if(imginary < 0 )
            {
                opreator = '-';
                imginary *= -1;
            }
            if (imginary == 0)
            {
                return $"{real}";
            }
            if (imginary == 1)
            {
                if (real == 0)
                {
                    if (opreator == '+')
                    {
                        return "i";
                    }
                    return $"{opreator}i";
                }
                return $"{real} {opreator}i";
            }
            if (real == 0)
            {
                return $"{opreator} {imginary}";
            }

            return $"{real} {opreator} {imginary}i";

        }
    }
}
