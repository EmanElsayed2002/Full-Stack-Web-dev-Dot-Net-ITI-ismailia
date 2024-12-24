namespace _06_Sixth_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TASK1
            
            int sizeOfArray;
            int counter = 0;
            int max = 0;
            


            Console.Write("Enter the size of the array: ");
            sizeOfArray = int.Parse(Console.ReadLine());


            int[] array = new int[sizeOfArray];
            


            for (int i = 0; i < array.Length; i++) { 
                Console.Write($"Enter the element no.{i+1} : ");
                array[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < array.Length; i++) {
                counter = 0;
                for (int j = i+1; j < array.Length; j++) {

                    if (array[i] == array[j]) {
                        if (counter > max) {
                            max= counter;
                        }
                    }
                    counter++;
                }
            }
            Console.WriteLine(max);
            #endregion
        }
    }
}
