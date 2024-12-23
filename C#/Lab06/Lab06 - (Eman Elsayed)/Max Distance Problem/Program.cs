namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Size OF Your Array: ");
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            int maxDis = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Element #{i + 1} : ");

                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        maxDis = int.Max(maxDis, j - i - 1);
                    }
                }
            }
            Console.WriteLine($"Max Distance amoung Array is : {maxDis}");
        }
    }
}
