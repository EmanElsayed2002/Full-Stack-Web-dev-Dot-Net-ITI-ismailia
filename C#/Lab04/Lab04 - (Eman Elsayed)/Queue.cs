using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Queue
    {
        int size, rear, front;
        int[] queue;
        public Queue()
        {
            rear = -1;
            front = 0;
            queue = new int[5];
        }

        public Queue(int _size)
        {

            size = _size;
            queue = new int[size];
        }

        public void Enqueue(int num)
        {
            if (!isFull())
                queue [rear++] = num;
            else
            {
                Console.WriteLine("Queue is Empty");
            }
        }

        public void Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty!!!!");
            }
            else
            {
               for(int i = 0; i < rear; i++)
                {
                    queue[i] = queue[i + 1];
                }
                rear--;
            }
        }

        public bool isFull()
        {
            return rear == size;
        }

        public bool isEmpty()
        {
            return front > rear;
        }

        public void Print()
        {

            for(int i = front; i < rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }

        public int GetFront()
        {
            if (isEmpty())
            {
                Console.WriteLine("Empty!!!!");
                return 0;
            }
            return queue[front];
        }

    }
}
