using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationProject
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion()
        {
            Console.WriteLine("TFQ created");
        }
        public TrueFalseQuestion(string header , string body , int mark) : base(header , body , mark) 
        {
            
        }
        public override void DisplayQuestion()
        {

            Console.WriteLine($"\t\t\t\t{Header}\n\t\t\t\t{Body}-{Mark} Marks\n\t\t\t\t\t\t1. True\n\t\t\t\t\t\t2. False");
        }

    }
}
