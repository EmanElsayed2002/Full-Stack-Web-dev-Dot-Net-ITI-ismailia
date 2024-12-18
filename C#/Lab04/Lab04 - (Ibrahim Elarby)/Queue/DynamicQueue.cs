using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5lab
{
    class DynamicQueue<T>
    {
        int front;
        int back;
        T[] arr;
        int size;
        int counter;
        public DynamicQueue()
        {
            counter = 0;
            front = -1;
            back = -1;
            size = 100;
            arr = new T[size];
        }
        public DynamicQueue(int _size)
        {
            counter=0;
            front = -1;
            back = -1;
            size = _size;
            arr = new T[size];
        }
        public bool isFull()
        {
            return counter == size ; 
        }
        public bool isEmpty()
        {

            return counter ==0 ;

        }

        public void enqueue(T item)
        {
            if(front == -1)
            {
            front++;
            }
            if(back == -1)
            {
                back++;
            }
           
            if (!isFull())
            {
               counter++;
                int curr = back % size;
                back++;
                arr[curr] = item;
                
            }
        }
        public T dequeue()
        {
            T item = default(T);
           

            if (!isEmpty())
            {
                counter--;
                int currf = front % size;
                front++;
                return arr[currf];
            }
            return item;
        }
        public void print()
        {
            if (isEmpty())
            {
                Console.WriteLine("empty queue");
                return;
            }
            int i = (front % size);
            for (int k = i ; k < i+counter; k++ )
            {
                Console.Write($"{arr[k%size]} ");
            }
            Console.WriteLine();
        }

        public T showFront()
        { return arr[front]; }
        public T showBack() { return arr[back]; }
    }
}
