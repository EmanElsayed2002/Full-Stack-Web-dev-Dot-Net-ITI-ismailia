using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationProject
{
    public class PracticalExam:Exam
    {

        public PracticalExam()
        {
            
        }
        public PracticalExam(string examName, int timeLimit, int numberOfQuestions) : base(examName, timeLimit, numberOfQuestions)
        {
            
        }




        public override void showExam()
        {
            Console.WriteLine("\t\t\t\tPractice Exam - Answers will be shown after each question.");
            foreach (var question in QuestionAnswerDict.Keys)
            {
                question.DisplayQuestion();
                Console.Write("\t\t\t\t\t\tEnter your answer: ");
                string answer = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\t\t\t\t\t\tCorrect Answer: {QuestionAnswerDict[question].AnswerText}\n");
                Console.ResetColor();
            }
        }
    }
}
