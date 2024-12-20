using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class MyQueue
    {
        int[] arr;
        int front;
        int back;

        int maxLength;
        int length;

        public MyQueue(int _maxLength)
        {
            arr = new int[_maxLength];
            front = 0;
            maxLength = _maxLength;
            back = maxLength - 1;
            length = 0;
        }


        public void Enqueue(int value)     
        {
            if (!IsFull())
            {
                back = (back + 1) % maxLength ;
                arr[back] = value;
                length++;
            }
            else
                Console.WriteLine("Queue is Full :(");
        }


        public int Dequeue()
        {
            int result;
            if(!IsEmpty())
            {
                result = arr[front];
                front = (front + 1) % maxLength ;

                length--;

                return result;
            }
            else
            {
                Console.WriteLine("Queue is Empty :(");
                return -1;
                
            }
        }










        public bool IsFull()
        {
            return length == maxLength;
        }

        public bool IsEmpty()
        {
            return length == 0;
        }
    }
}
