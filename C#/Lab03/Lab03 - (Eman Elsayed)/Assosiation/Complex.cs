using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
     class Complex
    {
        int real, img;

        public Complex()
        {
            real = img = 0;
            Console.WriteLine("Ctor created");
        }
        public Complex(int real, int img)
        {
            this.real = real;
            this.img = img;
        }
        public int getReal() { return real; }
        public int getImg() { return img; }

        public string Print()
        {


            if (real > 0)
            {
                if (img > 1)
                {
                    return $"{real} + {img}i";
                }
                else if (img == 1)
                {
                    return $"{real} + i";
                }
                else if (img == -1)
                {
                    return $"{real} -i";
                }
                else if (img == 0)
                {
                    return $"{real}";
                }
                else
                {
                    return $"{real} {img}i";
                }
            }
            else if (real == 0)
            {
                if (img > 1)
                {
                    return $"{img}i";
                }
                else if (img == 0)
                {
                    return "0";
                }
                else if (img == 1)
                {
                    return $"i";
                }
                else if (img == -1)
                {
                    return $"-i";
                }
                else
                {
                    return $" {img}i";
                }
            }
            else
            {
                if (img > 1)
                {
                    return $"{real} + {img}i";
                }
                else if (img == 1)
                {
                    return $"{real} + i";
                }
                else if (img == 0)
                {
                    return $"{real}";
                }
                else if (img == -1)
                {
                    return $"{real} - i";
                }
                else
                {
                    return $"{real}  {img}i";
                }
            }
        }

    }
}
