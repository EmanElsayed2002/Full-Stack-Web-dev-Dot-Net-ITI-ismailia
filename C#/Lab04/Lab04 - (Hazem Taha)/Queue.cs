using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__day_5
{
    class Queue
    {
        int size;
        int front;
        int back;
        int[] arr;
        int curent;
         int counter=0;

        public Queue()
        {
            size = 5;
            arr = new int[size];
            front = 0;
            back = size-1;
        }
        public Queue(int _size)
        {
            size = _size;
            arr = new int[size];
            front = 0;
            back = size-1;
        }

        public void EnQueue(int num)
        {

            if(!IsFull())
            {
                back = (back + 1) % size;
                counter++;
                arr[back] = num;

            }
            else
            {
                Console.WriteLine( "Full!!");
            }
           
           
        }

        public int DeQueue()
        {
            if(!IsEmpty())
            {
                
                counter--;
                front = (front + 1) % size;
                return arr[front];
               
            }
            else
            {
                Console.WriteLine("Empty!!");
                return -1;
            }
            
        }

        public bool IsFull()
        {
            return counter ==size;
        }
        public bool IsEmpty()
        {
            return counter == 0;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty");
                return;
             }
            int k = front;
            for (int i = front; i < k+counter; i++)
            {
                Console.Write($"{arr[i%size]} ");
            }
        }


    }
}
