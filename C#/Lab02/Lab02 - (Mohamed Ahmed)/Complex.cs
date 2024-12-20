using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Complex
    {
        private int real;
        private int img;

        public Complex()
        {
            
        }
        public Complex(int _real, int _img)
        {
            real = _real;
            img = _img;
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

        public string Print()
        {
     
            if(real == 0)
            {
                if (img > 1)
                    return $"{img}i";
                else if (img == 1)
                    return "i";
                else if (img == -1)
                    return "-i";
                else if (img < 0 && img != -1)
                    return $"{img}i";
            }

            if (img == 0)
                return $"{real}";
            else if (img == 1)
            {
                return $"{real} + i";
            }
            else if (img < 0 && img != -1)
            {
                return $"{real} - {img * -1}i";
            }
            else if (img == -1)
            {
                return $"{real} - i";
            }



            if (real == 0 && img == 0)
                return "0";

            return $"{real} + {img}i";
        }   

        public Complex Add(Complex right)
        {
            Complex result = new Complex();
            result.real = real + right.real;
            result.img = img + right.img;

            return result;
        }
    }
}
