using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifth_day
{
     class Queue
    {
        int size;
        int[] arr;
        int front;
        int rear;
        static int counter;
        
        public Queue()
        {
            size = 5;
            arr = new int[size];
            front= 0;
            rear = -1;
            
        }
        public Queue(int _size)
        {
            size = _size;
            arr = new int[size];
            front = 0;
            rear = -1;
        }
        public void Enqueue(int _data) {
            if (rear <(size-1))
            {
                rear++;
                arr[rear] = _data;
                
            }
            else {
                Console.WriteLine("Queue is Full");
            }
        }

        public int Dequeue(){
            int result = 0;
            if (front > rear)
            {
                Console.WriteLine("Queue is Empty");
            }
            else { 
                result = arr[front];
                for(int i = 0; i < rear; i++)
                {
                    arr[i] = arr[i+1];
                }
                rear--;
            }
          
            return result;
           
        }
        public bool IsFull()
        {
            if (rear == (size -1)) return true;
            else { return false; }
        }


        public bool IsEmpty()
        {
            if (rear == -1) return true;
            else return false;
        }
    }
    class CircularQueue
    {
        int size;
        int[] arr;
        int front;
        int rear;

        public CircularQueue()
        {
            size = 5;
            arr = new int[5];
            front = rear = -1;
            Console.WriteLine("ctor of Queue");
        }
        public CircularQueue(int _size)
        {
            size = _size;
            arr = new int[size];
        }

        public void EnQueue(int num)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }

            if (isEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear = (rear + 1) % size;
            }
            arr[rear] = num;
        }
        public int DeQueue()
        {
            front = (front + 1) % size;
            return arr[front];

        }

        public bool isFull()
        {
            return (rear + 1) % size == front;
        }

        public bool isEmpty()
        {
            return rear == -1;
        }

        public void Print()
        {
            for (int i = front; i < rear; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
        }
    }
}
