using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
	class DynamicStack
	{
		#region Data
		int[] arr;
		int tos;
		int size;
		
		private static int counter = 0; 
		#endregion

		#region Setters&getters
		public static int GetCounter()
		{
			return counter;
		}
		#endregion

		#region Ctors
		public DynamicStack()
		{
			counter++;
			size = 5;
			tos = 0;
			arr = new int[size];
		}
		public DynamicStack(int _size)
		{
			counter++;
			size = _size;
			tos = 0;
			arr = new int[size];
		}
		#endregion
		#region Stack Functions
		public void Push(int value)
		{
			
			if (!IsFull())
			{
				arr[tos] = value;
				tos++;
			}
			else
			{
				
				Console.WriteLine("FULL!!!!");
			}
		}
		public int Pop()
		{
			int result;
			
			if (!IsEmpty())
			{
				tos--;
				result = arr[tos];
				return result;
			}
			else
			{
				Console.WriteLine("EMPTY!!!!");
				return -123;
				
			}
		}

		public bool IsFull()
		{
			return tos == size;
		}
		public bool IsEmpty()
		{
			return tos == 0;
		}
		#endregion
	}
}
