using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
     class DynamicStack
    {

        int[] arr;
        int size;
        int top;
        static int cnt = 0;

        public DynamicStack()
        {
            size = 5;
            top = 0;
            arr = new int[size];
            cnt++;
        }

        public DynamicStack(int _size)
        {
            size = _size;
            arr = new int[size];
        }

        public void  Push(int num)
        {
            if(!isFull())
            arr[top++] = num;
            else
            {
                Console.WriteLine("Full!!!!");
            }
        }

        public int Pop()
        {
            if(!isEmpty())
                return arr[--top];
            else{
                Console.WriteLine("Empty!!!!");
            }

            return 0;
        }

        public int Size()
        {
            return top;
        }


        public bool isEmpty()
        {
            return top == 0;
        }

        public int GetTop() {
            if (top == 0)
            {
                Console.WriteLine("IS Empty!!!");
                return 0;
            }
            else
                return arr[top - 1];
        }

        public int GetCount() {
            return cnt;
        }

        public bool isFull()
        {
            return top == size;
        }

        public void Print()
        {
            Console.WriteLine("Array Items:");
            for(int i = 0; i < top; i++)
            {
                Console.Write(arr[i]+"\t");
            }
        }
    }
}
