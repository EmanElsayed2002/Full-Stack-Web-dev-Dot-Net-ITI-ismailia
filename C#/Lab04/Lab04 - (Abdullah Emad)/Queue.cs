using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
	class Queue
	{
		int[] arr;
		int queue_index;
		int size;
		private static int counter = 0;
		


		public static int GetCounter()
		{
			return counter;
		}

		public Queue()
		{
			counter++;
			size = 5;
			queue_index = 0;
			arr = new int[size];
		}public Queue(int _size)
		{
			counter++;
			size = _size;
			queue_index = 0;
			arr = new int[size];
		}


		public bool IsFull()
		{
			return queue_index == size;
		}
		public bool IsEmpty()
		{
			return queue_index == 0;
		}

		public void Enqueue(int value)
		{

			if (!IsFull())
			{
				arr[queue_index] = value;
				queue_index++;
			}
			else
			{

				Console.WriteLine("FULL!!!!");
			}
		}


		public int Dequeue()
		{
			int result;
			
			if (!IsEmpty())
			{
				queue_index--;
				result = arr[0];
				for(int n=0;n< queue_index; n++)
				{
					arr [n] = arr [n+1];
				}
				return result;
			}
			else
			{
				Console.WriteLine("EMPTY!!!!");
				return -123;

			}
		}

	}
}
