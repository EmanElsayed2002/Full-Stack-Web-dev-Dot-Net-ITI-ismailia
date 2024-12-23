namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Way One
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();
            int cnt = 1;
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    cnt++;
                }
            }
            string[] words = new string[cnt];
            int idx = 0;
            string letters = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    words[idx++] = letters;
                    letters = "";
                }
                else
                letters += input[i];
            }
            words[idx++] = letters;

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }

            #endregion



            #region using builtin Function
            //Console.WriteLine("Enter a sentence:");
            //string input = Console.ReadLine();

            //string output = string.Join(" ", input.Split(' ').Reverse());

            //Console.WriteLine($"Reversed sentence: {output}");
            #endregion
        }
    }
}
