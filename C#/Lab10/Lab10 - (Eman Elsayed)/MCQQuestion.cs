using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationProject
{
    public class MCQQuestion : Question
    {
        public AnswersList Choices { get; set; }
        public MCQQuestion(string header, string body, int mark, AnswersList options): base(header, body, mark)
        {
            Choices = options;
        }
        public override void DisplayQuestion()
        {
            Console.WriteLine($"\t\t\t\t{Header}\n\t\t\t\t{Body}");
            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"\t\t\t\t\t\t{i + 1}. {Choices[i].AnswerText}");
            }
        }
    }
}
