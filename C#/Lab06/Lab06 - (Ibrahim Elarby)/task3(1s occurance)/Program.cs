using task2.task2;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arr2 = "my name is ibrahim";

            Console.WriteLine(string.Join(" ",arr2.Split(" ").Reverse()));
        }
    }
}
