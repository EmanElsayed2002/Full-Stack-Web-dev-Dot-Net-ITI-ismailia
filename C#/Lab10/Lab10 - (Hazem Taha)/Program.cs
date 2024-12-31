namespace Day11CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MCQ> MCQs = new List<MCQ>();

            List<Answer> ans1 = new List<Answer>();
            ans1.Add(new Answer("1. class"));
            ans1.Add(new Answer("2. void"));
            ans1.Add(new Answer("3. method"));
            ans1.Add(new Answer("4. define"));

            Answer ansQ1 = new Answer("2. void");

            MCQs.Add(new MCQ("What keyword is used to define a method in C#?", "Question Num 1", 2, ans1));

            /////////////////////////////////////////////////////

            List<Answer> ans2 = new List<Answer>();
            ans2.Add(new Answer("1. int"));
            ans2.Add(new Answer("2. string"));
            ans2.Add(new Answer("3. bool"));
            ans2.Add(new Answer("4. char"));

            Answer ansQ2 = new Answer("3. bool");

            MCQs.Add(new MCQ("Which data type is used to store true or false values in C#?", "Question Num 2", 2, ans2));

            /////////////////////////////////////////////////////

            List<Answer> ans3 = new List<Answer>();
            ans3.Add(new Answer("1. #"));
            ans3.Add(new Answer("2. //"));
            ans3.Add(new Answer("3. /*"));
            ans3.Add(new Answer("4. <!--"));

            Answer ansQ3 = new Answer("2. //");

            MCQs.Add(new MCQ("How do you write a single-line comment in C#?", "Question Num 3", 2, ans3));

            /////////////////////////////////////////////////////

            List<Answer> ans4 = new List<Answer>();
            ans4.Add(new Answer("1. extends"));
            ans4.Add(new Answer("2. inherits"));
            ans4.Add(new Answer("3. super"));
            ans4.Add(new Answer("4. :(colon)"));

            Answer ansQ4 = new Answer("4. :(colon)");

            MCQs.Add(new MCQ("Which keyword is used to inherit a class in C#?", "Question Num 4", 2, ans4));

            /////////////////////////////////////////////////////

            List<Answer> ans5 = new List<Answer>();
            ans5.Add(new Answer("1. :"));
            ans5.Add(new Answer("2. ;"));
            ans5.Add(new Answer("3. ,"));
            ans5.Add(new Answer("4. ."));

            Answer ansQ5 = new Answer("2. ;");

            MCQs.Add(new MCQ("What symbol is used to terminate a statement in C#?", "Question Num 5", 2, ans5));

            /////////////////////////////////////////////////////

            List<Answer> ans6 = new List<Answer>();
            ans6.Add(new Answer("1. constant int x = 10;"));
            ans6.Add(new Answer("2. readonly int x = 10;"));
            ans6.Add(new Answer("3. const int x = 10;"));
            ans6.Add(new Answer("4. static int x = 10;"));

            Answer ansQ6 = new Answer("3. const int x = 10;");

            MCQs.Add(new MCQ("How do you declare a constant in C#?", "Question Num 6", 2, ans6));

            /////////////////////////////////////////////////////

            List<Answer> ans7 = new List<Answer>();
            ans7.Add(new Answer("1. for"));
            ans7.Add(new Answer("2. while"));
            ans7.Add(new Answer("3. do-while"));
            ans7.Add(new Answer("4. foreach"));

            Answer ansQ7 = new Answer("3. do-while");

            MCQs.Add(new MCQ("Which loop runs at least once even if the condition is false?", "Question Num 7", 2, ans7));

            /////////////////////////////////////////////////////

            List<Answer> ans8 = new List<Answer>();
            ans8.Add(new Answer("1. true"));
            ans8.Add(new Answer("2. 0"));
            ans8.Add(new Answer("3. false"));
            ans8.Add(new Answer("4. null"));

            Answer ansQ8 = new Answer("3. false");

            MCQs.Add(new MCQ("What is the default value of a boolean in C#?", "Question Num 8", 2, ans8));

            /////////////////////////////////////////////////////

            List<Answer> ans9 = new List<Answer>();
            ans9.Add(new Answer("1. if (condition) { // code }"));
            ans9.Add(new Answer("2. if condition: // code"));
            ans9.Add(new Answer("3. if { condition } // code"));
            ans9.Add(new Answer("4. if condition { // code"));

            Answer ansQ9 = new Answer("1. if (condition) { // code }");

            MCQs.Add(new MCQ("What is the syntax to write an if statement in C#?", "Question Num 9", 2, ans9));

            /////////////////////////////////////////////////////

            List<Answer> ans10 = new List<Answer>();
            ans10.Add(new Answer("1. Person p = Person();"));
            ans10.Add(new Answer("2. new Person p;"));
            ans10.Add(new Answer("3. Person p = new Person();"));
            ans10.Add(new Answer("4. Person p = new Person;"));

            Answer ansQ10 = new Answer("3. Person p = new Person();");

            MCQs.Add(new MCQ("How do you create a new instance of a class called `Person` in C#?", "Question Num 10", 2, ans10));

            /////////////////////////////////////////////////////

            List<Answer> correctAnswers = new List<Answer>();

            correctAnswers.Add(ansQ1);
            correctAnswers.Add(ansQ2);
            correctAnswers.Add(ansQ3);
            correctAnswers.Add(ansQ4);
            correctAnswers.Add(ansQ5);
            correctAnswers.Add(ansQ6);
            correctAnswers.Add(ansQ7);
            correctAnswers.Add(ansQ8);
            correctAnswers.Add(ansQ9);
            correctAnswers.Add(ansQ10);

            Dictionary<Question, Answer> QuestionsAndAnswers = new Dictionary<Question, Answer>();

            for (int i = 0; i < MCQs.Count; i++)
            {
                QuestionsAndAnswers.Add(MCQs[i], correctAnswers[i]);
            }

            FinalExam final = new FinalExam(20,10,DateTime.Today, QuestionsAndAnswers);
            PracticeExam Practice = new PracticeExam(20,10,DateTime.Today, QuestionsAndAnswers);
            //  final.ShowExam();
            //  Practice.ShowExam();
            // final.ShowExamV2();
            Practice.ShowExamV2();
            

        }
    }
}
