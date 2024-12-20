using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace fifth_day
{
    class Stack
    {

        int[] arr;
        int data;
        int tos;
        int size;
        static int counter=0;
        public Stack()
        {
            size = 5;
            tos = 0;
            arr = new int[size];
            counter++;
        }
        public Stack(int _size)
        {
            size = _size;
            tos = 0;
            arr = new int[size];
            counter++;
        }
        //get the counter
        public static int GetCounter() { return counter; }
        public void Push(int _data)
        {
            if (tos!=size)
            {
                arr[tos] = _data;
                tos++;
            }
            else {
                Console.WriteLine("OOPS, Stack is full");
            }

        }

        public int Pop()
        {
            int result_data = 0;
            if (tos!=0)
            {
                tos--;
                result_data = arr[tos];
            }
            else
            {
                Console.WriteLine("OOPS, Stack is empty");
            }
            return result_data;
        }

        public bool IsFull() {
            if (tos == size) return true;
            else { return false; }
        }


        public bool IsEmpty() {
            if(tos == 0) return true;
            else return false;
        }

        public void print() {
            for (int i = 0; i < tos; i++) {
                Console.WriteLine($"Element no.{i+1} : {arr[i]}");
            }
        }
    }
}
