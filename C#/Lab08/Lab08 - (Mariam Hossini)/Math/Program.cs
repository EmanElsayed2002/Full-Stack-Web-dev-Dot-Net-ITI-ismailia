namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MATH
            int x;
            int y;
            Console.WriteLine("Please enter Two numbers: ");
            Console.Write("Enter the first number:  ");
            x= int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:  ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine($"The add of numbers = {Math.Add(x,y)}");
            Console.WriteLine($"The subtraction of numbers = {Math.Subtract(x, y)}");
            Console.WriteLine($"The multiplication of numbers = {Math.Multiply(x, y)}");
            Console.WriteLine($"The division of numbers = {Math.Divide(x, y)}");
            #endregion
        }
    }
}
