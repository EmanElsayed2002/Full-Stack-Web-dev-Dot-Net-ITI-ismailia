using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day11CS
{
    abstract public class Exam
    {
        public int ExamTime { get; set; }
        public string Category { get; set; }

        public int QustionNumbers { get; set; }
        public DateTime ExamDate{ get; set; }
        public int Score { get; set; }

        public Dictionary<Question, Answer> ExamQusetions { get; set; }

        
        
        protected Exam(int _examTime,string _category,int _numQuestion,DateTime _examDate, Dictionary<Question, Answer> _examQusetions)
        {
            ExamTime = _examTime;
            Category = _category;
            QustionNumbers = _numQuestion;
            ExamDate = _examDate;
            ExamQusetions= _examQusetions;
        }

        public virtual void ShowExam()
        {
            
        }

        public virtual void ShowExamV2()
        {

        }

    }
}
