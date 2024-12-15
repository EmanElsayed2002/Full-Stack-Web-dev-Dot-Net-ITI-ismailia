using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Complex
    {
        private int real;
        private int imaginary;

        public void SetReal(int _real)
        {
            real = _real;
        }

        public int GetReal()
        {
            return real;
        }

        public void SetImg(int _img)
        {
            imaginary = _img;
        }

        public int GetImg()
        {
            return imaginary;
        }

        public string Print()
        {

            
             if(real > 0)
            {
                if (imaginary > 1)
                {
                    return $"{real} + {imaginary}i";
                }
                else if (imaginary == 1)
                {
                    return $"{real} + i";
                }
                else if (imaginary == -1)
                {
                    return $"{real} -i";
                }
                else if (imaginary == 0)
                {
                    return $"{real}";
                }
                else
                {
                    return $"{real} {imaginary}i";
                }
            }
            else if(real  == 0)
            {
                if (imaginary > 1)
                {
                    return $"{imaginary}i";
                }
                else if (imaginary == 0)
                {
                    return "0";
                }
                else if (imaginary == 1)
                {
                    return $"i";
                }
                else if (imaginary == -1)
                {
                    return $"-i";
                }
                else
                {
                    return $" {imaginary}i";
                }
            }
            else
            {
                if (imaginary > 1)
                {
                    return $"{real} + {imaginary}i";
                }
                else if (imaginary == 1)
                {
                    return $"{real} + i";
                }
                else if (imaginary == 0)
                {
                    return $"{real}";
                }
                else if (imaginary == -1)
                {
                    return $"{real} - i";
                }
                else
                {
                    return $"{real}  {imaginary}i";
                }
            }
        }

        public Complex Add(Complex c)
        {
            Complex res = new Complex();
            res.real = real + c.real;
            res.imaginary = imaginary + c.imaginary;
            return res;
        }
    }
}
