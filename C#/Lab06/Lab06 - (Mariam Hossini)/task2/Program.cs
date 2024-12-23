namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reverse the sentence
            string sentence;
            Console.Write("Enter the Sentence: ");
            sentence = Console.ReadLine();

            //first method
            string[] words = sentence.Split(" ");
            for (int i = words.Length-1; i >=0; i--) { Console.Write($"{words[i]} "); }

            Console.WriteLine();


            //second method
            
            ///split->reverse->join
            Console.WriteLine(string.Join(" ", sentence.Split(" ").Reverse()));

        }
    }
}
