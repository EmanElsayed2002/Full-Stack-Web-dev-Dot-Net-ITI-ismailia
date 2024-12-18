using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
     class CircularQueue
    {
        int size, front, rear, count;
        int[] Queue;

        public CircularQueue()
        {
            size = 5; 
            Queue = new int[size];
            front = 0;
            rear = -1;
            count = 0;
        }

        public CircularQueue(int _size)
        {
            size = _size;
            Queue = new int[size];
            front = 0;
            rear = -1;
            count = 0;
        }

        public void Enqueue(int value)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full! Cannot enqueue " + value);
                return;
            }

            rear = (rear + 1) % size; 
            Queue[rear] = value;
            count++;
        }

        public int Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty! Cannot dequeue.");
                return -1; 
            }

            int value = Queue[front];
            front = (front + 1) % size;
            count--;
            return value;
        }

        public void Print()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Elements in the Circular Queue:");
            for (int i = 0; i < count; i++)
            {
                int index = (front + i) % size;
                Console.Write(Queue[index] + "\t");
            }
            Console.WriteLine();
        }

       
        public bool isFull()
        {
            return count == size;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int GetFront()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty! No front element.");
                return -1; 
            }
            return Queue[front]; 
        }


    }
}
