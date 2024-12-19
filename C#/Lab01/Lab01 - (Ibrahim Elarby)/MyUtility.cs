using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace c_daylab
{
    class MyUtility
    {
        
        #region max methods
        // we using Templates to use it with any data type array but whe Implements the interface INumber to use only numric data types like int , float,decimal ,double
        // thats means those types are the only types that implements the interface INumber (supported from .NET v7)
        static bool compareNumber<T>(T value1, T value2) where T : INumber<T>
        {
            //here we are retrining true if value1 is bigger false if value2 is bigger  
            return value1  > value2 ;
        }

        
        public static T findMax<T>(T[] numbers ) where T : INumber<T> 
        {
            // to get the maximum of array we should make the max number the first element then check 
            //whether there is a bigger number than him or not 
            T max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (compareNumber( numbers[i],max))
                { max = numbers[i]; }
            }
            return max;
        }
        // we made this method to make the print eaiser and follow single responsibility princible
        public static string printMax<T>(T[] numbers) where T : INumber<T>
        {

            return $"the max number in the array is {findMax(numbers)}";
        }

        #endregion
        #region minimum methods
        // we using Templates to use it with any data type array but whe Implements the interface INumber to use only numric data types like int , float,decimal ,double
        // thats means those types are the only types that implements the interface INumber (supported from .NET v7)
       


        public static T findMinimum<T>(T[] numbers) where T : INumber<T>
        {
            // to get the minimum of array we should make the max number the first element then check 
            //whether there is a smaller number than him or not 
            T min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (compareNumber(min,numbers[i]))
                { min = numbers[i]; }
            }
            return min;
        }
        // we made this method to make the print eaiser and follow single responsibility princible
        public static string printMinimum<T>(T[] numbers) where T : INumber<T>
        {

            return $"the minimum number in the array is {findMinimum(numbers)}";
        }
        #endregion
        #region sorting
        //enum to make the code more readable
        public enum Way
        {
            Ascending = 0,
            Descending,
        }
        //here we will use simple sort method called bubble sort 
        //it find the smallest number in every iteration it has easiest implementation but not most effective algorithm 
        public static void sort<T>(T[]array,Way way)where T : INumber<T>
        {
            for(int i = 0; i < array.Length;i++)
            {
                for (int j = 0; j<array.Length;j++)
                {
                    if (way == Way.Ascending ? /*Ascending from small to big*/compareNumber(array[j], array[i]) :/*decending from big to small*/ compareNumber(array[i], array[j]) )
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        #endregion
        #region print array (not recommended)
        public static void printArray<T>(T[]array)
        {
                Console.WriteLine("Printing Array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        #endregion
        #region find number
        //we want to find any type of numric data so we will use data that implements the interface INumber
        //find number function will return index so it will return integer
        public static int findNumber<T>(T[] numbers, T number)where T : INumber<T>
        {
            for (int i = 0; i < numbers.Length;i++)
            {
                if (numbers[i] == number)
                {
                    //we will check every number in the array with the target number if equal return index
                    return i;
                }
            }
            //if the code continued here that means the number is not in this group
                return -1;
        }
        #endregion
    }
}
