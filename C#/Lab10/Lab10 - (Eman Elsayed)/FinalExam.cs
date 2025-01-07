using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationProject
{
    public class FinalExam : Exam
    {

        public FinalExam()
        {

        }
        public FinalExam(string examName, int timeLimit, int numberOfQuestions)
       : base(examName, timeLimit, numberOfQuestions) { }
        

        public void AddQuestionsAndAnswers(QuestionsList questions, AnswersList answers)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                QuestionAnswerDict.Add(questions[i], answers[i]);
            }
        }

       
        public override void showExam()
        {
            Console.WriteLine("\t\t\t\t\t\tFinal Exam");
            foreach (var question in QuestionAnswerDict.Keys)
            {
                question.DisplayQuestion();
                Console.Write("\t\t\t\t\t\tEnter your answer: ");
                string answer = Console.ReadLine();
                if (answer == QuestionAnswerDict[question].AnswerText)
                {
                    StudentMarks++;
                }
            }
        }

       
       

    }
}
