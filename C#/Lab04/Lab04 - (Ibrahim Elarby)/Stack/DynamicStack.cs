using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_day5lab
{
    class DynamicStack<T>
    {
        int tos;
        T[] arr;
        int size;
        static int count; 
        public DynamicStack()
        {
            count = 0;
            tos = 0;
            size = 100;
            arr = new T[size];
        }
        public DynamicStack(int _size)
        {
            count = 0;
            tos = 0;
            size = _size;
            arr = new T[size];
        }
        public bool isFull()
        {
            return tos == size;
        }
        public bool isEmpty()
            { return tos == 0; }

        public void push(T item)
        {
            if (!isFull())
            {
                arr[tos++] = item;
            }
        }
        public T pop()
        {
            T item = default(T) ;
            
            if(!isEmpty())
            {
                return arr[--tos];
            }
            return item  ;
        }

        public void print()
        {
            if(isEmpty())
            {
                Console.WriteLine("empty stack");
                return;
            }
            for (int i = 0; i < tos; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public T Top()
            { return arr[tos-1]; }
    }
}
