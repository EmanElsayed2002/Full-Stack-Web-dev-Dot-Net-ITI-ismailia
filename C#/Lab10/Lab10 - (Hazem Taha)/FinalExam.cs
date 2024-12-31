using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11CS
{
    public class FinalExam:Exam
    {

        public FinalExam(int _examTime, int _numQuestion, DateTime _examDate, Dictionary<Question, Answer> _examQusetions) : base(_examTime,"Final Exam",_numQuestion,_examDate,_examQusetions)
        {
            
        }
        public override void ShowExam()
        {
            Console.WriteLine("Exam Details:");
            Console.WriteLine($"Exam Time: {ExamTime} minutes");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Number of Questions: {QustionNumbers}");
            Console.WriteLine($"Exam Date: {ExamDate.ToString("yyyy,mmm,dd")}");
            Console.WriteLine("\nQuestions and Answers:");

            int questionNumber = 1;
            foreach (var item in ExamQusetions)
            {
                Console.WriteLine($"\nQuestion {questionNumber}: {item.Key.Body}");

                foreach (var ch in item.Key.Choises)
                    { Console.WriteLine(ch); }

                    questionNumber++;
            }
        }

        // Bonus
        public override void ShowExamV2()
        {
           
            int questionNumber = 1;
            
            List<int> userAnswers = new List<int>();

            foreach (var item in ExamQusetions)
            {
                Console.WriteLine("Exam Details:");
                Console.WriteLine($"Exam Time: {ExamTime} minutes");
                Console.WriteLine($"Category: {Category}");
                Console.WriteLine($"Number of Questions: {QustionNumbers}");
                Console.WriteLine($"Exam Date: {ExamDate.ToString("yyyy,MMM,dd")}");
                Console.WriteLine("\nQuestions and Answers:");
                Console.WriteLine($"\nQuestion {questionNumber}: {item.Key.Body}");

                foreach (var ch in item.Key.Choises)
                { Console.WriteLine(ch); }

                int userAnswer;
                bool validAnswer = false;
                do
                {
                    Console.Write("Your Answer (1-4): ");
                    string input = Console.ReadLine();
                    validAnswer = int.TryParse(input, out userAnswer) && userAnswer >= 1 && userAnswer <= 4;

                    if (!validAnswer)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                        
                    }
                } while (!validAnswer);

                userAnswers.Add(userAnswer);
               
                if (item.Key.Choises[userAnswer-1] == item.Value)
                {
                    Score++;
                }
                questionNumber++;
                Console.Clear();
            }

            Console.WriteLine($"\nYour total score is: {Score}/{QustionNumbers}");
        }



    }
}
