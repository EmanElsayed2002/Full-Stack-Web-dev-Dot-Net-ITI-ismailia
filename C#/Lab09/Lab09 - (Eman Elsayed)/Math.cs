using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CS
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public Calculator()
        {
            Console.WriteLine("Calculator Class Initialized :)");
        }

        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return int.MinValue;
            }
            return firstNumber / secondNumber;
        }
    }
}
