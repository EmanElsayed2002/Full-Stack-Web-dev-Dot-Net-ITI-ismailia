using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class MyStack
    {
        int[] arr;
        int top;
        int size;

        private static int counter = 0;

        public static int GetCounter()
        {
            return counter;
        }
        public MyStack()
        {
            counter++;
            size = 5;
            top = 0;
            arr = new int[size];
        }

        public MyStack(int _size)
        {
            counter++;
            top = 0;
            size = _size;
            arr = new int[size];
        }

        public void Push(int value)
        {
            if (!IsFull())
            {
                arr[top++] = value;
            }
            else
            {
                Console.WriteLine("Stack is Full :(");
            }
        }

        public int Pop()
        {
            int result;
            if (!IsEmpty())
            {
                result = arr[--top];
                return result;
            }
            else {
                Console.WriteLine("Stack is Empty :(");
                return -1;
            }
                
        }

        public bool IsFull()
        {
            return top == size;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }
    }
}
