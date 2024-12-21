using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__day4
{
     class Complex
    {
        int real;
        int img;
        public Complex()
        {
            real = 3;
            img = 4;
        }

        public Complex(int _real,int _img)
        {
            real = _real;
            img = _img;
        }

        public Complex(int _num)
        {
            real = img = _num;
        }
        public void SetReal(int _real)
        {
            real = _real;
        }
        public void SetImg(int _img)
        {
            img = _img;
        }
        public int GetReal()
        {
            return real;
        }
        public int GetImg()
        {
            return img;
        }
        ///real img
        ///3    4    3+4i    *
        ///3    -4    3-4i    *
        ///3    1    3+i    *
        ///3    -1    3-i  *
        ///3    0     3  *
        ///0    3     3i *
        ///0    1     i  *
        ///0    -1    -i *
        ///0    0     0
        public string Print()
        {
            if (img < 0)
            {
                return $"{real} {img}i";
            }
            else if (img == 1)
            {
                return $"{real} + i";
            }
            else if (img == -1)
            {
                return $"{real} - i";
            }
            else if (img == 0)
            {
                return $"{real}";
            }
            else if (real == 0 && img == 1)
            {
                return $"i";
            }
            else if (real == 0 && img == -1)
            {
                return $"-i";
            }
            else if (real == 0 && img > 1)
            {
                return $"{img}i";
            }
            else return $"0";

        }
        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real =real + right.real;
            result.img =img + right.img;
            return result;
        }
        


    }
}
