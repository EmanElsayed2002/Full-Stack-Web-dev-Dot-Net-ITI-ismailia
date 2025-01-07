using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationProject
{
    public abstract class Exam
    {
        public string ExamName { get; set; }
        public int Duration { get; set; }
        public int NumberOfQuestions { get; set; }
        public QuestionsList Questions { get; set; }
        public Dictionary<Question, Answer> QuestionAnswerDict { get; set; }
        public int StudentMarks { get; set; }
        public Exam()
        {
            StudentMarks = 0;
            Console.WriteLine("Your Exam is Created");
        }

        public Exam(string examName, int timeLimit, int numberOfQuestions )
        {
            ExamName = examName;
            Duration = timeLimit;
            NumberOfQuestions = numberOfQuestions;
            QuestionAnswerDict = new Dictionary<Question, Answer>();
            
        }

        public abstract void showExam();



        public override string ToString()
        {
            return $"Exam: , Duration:  minutes";
        }

    }
}
