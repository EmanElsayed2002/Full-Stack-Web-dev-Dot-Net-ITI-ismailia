using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_third
{
    class Complex
    {
        int real;
        int imag;
        public int  GetReal() { 
            return real;
        }
        public int GetImag()
        {
            return imag;
        }
        public void SetReal( int _real) {
            real= _real;
        }

        public void SetImag(int _imag)
        {
            imag = _imag;
        }
        public string print() {
            string result ="";
            if (imag > 0) {
                if (imag == 1)
                {
                    if (real == 0)
                    {
                        result = "i";
                    }
                    else {
                        result = $"{real} + i";
                    }
                }
                else {
                    result = $"{real} + {imag}i";
                }

            }
            else if (imag < 0) {
                if (imag == -1)
                {
                    if (real == 0)
                    {
                        result = "-i";
                    }
                    else
                    {
                        result = $"{real} - i";
                    }
                }
                else
                {
                    result = $"{real} - {imag}i";
                }
            }
            else if (real == 0 && imag == 0) {
                result = "0";

            }
            else if (real == 0)
            {
                result = $"{imag}i";

            }
            else if (imag ==0)
            {
                result = $"{real}";
            }
            return result ;
        }
        public Complex add( Complex num)
        {
            Complex complex_num = new Complex();
            complex_num.SetReal(GetReal() + num.GetReal());
            complex_num.SetImag(GetImag() + num.GetImag());
            return complex_num;
        }
    }

    
}
