namespace Task2_Math_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathv1 m = new Mathv1();
            double x = 3.5;
            double y = 8.5;
            Console.WriteLine($"x = {x} , y = {y}");
            Console.WriteLine($"x + y = {MyMath.Add(x,y)}");
            Console.WriteLine($"x - y = {MyMath.Sub(x,y)}");
            Console.WriteLine($"x * y = {MyMath.Mult(x,y)}");
            Console.WriteLine($"x / y = {MyMath.Divide(x,y)}");
            Console.WriteLine($"x + y = {m.Add(x, y)}");
            Console.WriteLine($"x - y = {m.Sub(x, y)}");
            Console.WriteLine($"x * y = {m.Mult(x, y)}");
            Console.WriteLine($"x / y = {m.Divide(x, y)}");
        }
    }
}
