using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2.task2
{
    #region task 2 (not recomendded string concatination more meomry)
    class myString
    {
        public static string reverseString (string str)
        {
            string[] strings = str.Split(" ");
            string res = string.Empty;
            for (int i = strings.Length - 1; i >= 0; i--)
            {
                res += strings[i]+" ";
            }
            return res;
        }
    }
    #endregion
}
