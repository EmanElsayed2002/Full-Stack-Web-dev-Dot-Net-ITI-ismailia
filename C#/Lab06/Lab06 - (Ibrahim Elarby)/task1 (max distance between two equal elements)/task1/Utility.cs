using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.task1
{
    class Utility
    {
        #region first Task O(n power 2) 
        public static int findMaxspace(int[]arr)
        {
            int max = 0;
            int count = 0;
            
            for (int i = 0; i < arr.Length; i++) 
            {
                count = 1; 
                for (int j = i+1; j <arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {

                        if (count > max)
                        {
                            max = count;
                        }
                    }
                    count++;
                }
               
            }
            return max - 1  ;
        }
        #endregion
    }
}
