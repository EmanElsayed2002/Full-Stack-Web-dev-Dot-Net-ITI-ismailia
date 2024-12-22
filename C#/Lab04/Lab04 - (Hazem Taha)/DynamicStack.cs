using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__day_5
{
    class DynamicStack
    {
        int tos;
        int size;
        int[] arr;
        public static int counter ;
        public DynamicStack()
        {
            tos = 0 ;
            size = 5 ;
            arr = new int[5];
            DynamicStack.counter++;
        }
        public DynamicStack(int _size)
        {
            tos = 0;

            size = _size;
            arr = new int[size];
            DynamicStack.counter++;
        }

        public int get_tos() { return tos ; }

        public void Push(int num)
        {
            if(!IsFull())
            {
                arr[tos++] = num ;
            }
            else
            {
                Console.WriteLine("FULL!!!");
            }
        }
        public int  Pull()
        {
            int res = 0;
          
            if(!IsEmpty())
            {
                tos--;
                return arr[tos];
            }
            else
            {
                Console.WriteLine("Empyt!!!");
                return -111;
            }
        }

        public bool IsFull()
        {
            return tos == size;
        }

        public bool IsEmpty()
        {
            return tos == 0 ;
        }

        public void Print()
        {
            for (int i = 0; i < tos; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }


    }
}
