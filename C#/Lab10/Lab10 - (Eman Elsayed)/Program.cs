using System.Drawing;

namespace ExaminationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t\t\tWelcome to the Examination System!");

            var questions = new QuestionsList
            {
                new TrueFalseQuestion("Q1: ", "In C#, the 'bool' data type can store values?", 1),
                new TrueFalseQuestion("Q2: ", "C# is a statically typed language?", 1),
                new MCQQuestion("Q3: ", "Which of the following is NOT a valid data type in C#?", 1,
                new AnswersList { new Answer("bool"), new Answer("float"), new Answer("string") , new Answer("integer") }), // 4
                new MCQQuestion("Q4: ", "What is the default value of a bool variable in C#?", 1,
                new AnswersList { new Answer("true"), new Answer("false"), new Answer("null"), new Answer("undefined") }) // 2
            };
            AnswersList answers = new AnswersList()
            {
                new Answer("1"),new Answer("1"), new Answer("4") , new Answer("2")
            };


            var practicalExam = new PracticalExam("C# Exam", 60, 4);
            var finalExam = new FinalExam("C# Exam", 60, 4);

            for (int i = 0; i < questions.Count; i++)
            {
                practicalExam.QuestionAnswerDict.Add(questions[i], answers[i]);
                finalExam.QuestionAnswerDict.Add(questions[i], answers[i]);
            }
            int choice = -1;
            char again = 'n';
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t\t\t\t\tSelect Exam Type:\n\t\t\t\t\t\t1. Practice Exam\n\t\t\t\t\t\t2. Final Exam\n\t\t\t\t\t\t3. Exit");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\t\t\t\t\t\tEnter Your Choice: ");
                    Console.ResetColor();
                    choice = int.Parse(Console.ReadLine());
                } while (choice < 1 || choice > 3);
                switch (choice)
                {
                    case 1:
                        practicalExam.showExam();
                        break;
                    case 2:
                        finalExam.showExam();
                        if ((finalExam.StudentMarks >= questions.Count / 2))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\t\t\t\t\t\tYour Score: {finalExam.StudentMarks}/{questions.Count}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\t\t\t\t\t\tYour Score: {finalExam.StudentMarks}/{questions.Count}");
                            Console.WriteLine("\t\t\t\t\t\tWork Hard!!");
                            Console.ResetColor();
                        }
                        
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t\t\t\t\t\tDo you need Test Again (Y/N): ");
                again =char.ToLower(char.Parse(Console.ReadLine()));
                Console.ResetColor();
                Console.WriteLine("\t\t\t\t\t===========================================");
            } while (again != 'n');
            

        }
    }
}

