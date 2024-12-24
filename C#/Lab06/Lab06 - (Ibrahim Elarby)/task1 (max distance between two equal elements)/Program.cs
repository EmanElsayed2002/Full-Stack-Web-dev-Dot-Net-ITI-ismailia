using task1.task1;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 0, 0, 0, 5, 6, 7,  0, 7, 5, 7 };
            int max = Utility.findMaxspace(arr);
            Console.WriteLine(max);
            int size;
            Console.WriteLine("enter the size of the array");
            size = int.Parse(Console.ReadLine());
            int[] userarr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter element number#{i} ");
                userarr[i]= int.Parse(Console.ReadLine());
            }
            int max2 = Utility.findMaxspace(userarr);
            Console.WriteLine(max2);
        }
    }
}
