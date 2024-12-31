using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11CS
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public Answer(string _answer)
        {
            AnswerText = _answer;
        }
        public override string ToString()
        {
            return $"==>{AnswerText}";
        }

        public static bool operator ==(Answer left,Answer right)
        {
            return left.AnswerText == right.AnswerText ;
        }
        public static bool operator !=(Answer left, Answer right)
        {
            return left.AnswerText != right.AnswerText;
        }
    }
}
