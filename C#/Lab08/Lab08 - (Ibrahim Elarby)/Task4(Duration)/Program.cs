namespace Task4_Duration_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration d1 = new Duration(1,10,15);
            Duration d2 = new Duration(3600);
            Duration d3 = new Duration(7800);
            Duration d4 = new Duration(666);
            Console.WriteLine($"d1 {d1}");
            Console.WriteLine($"d2 {d2}");
            Console.WriteLine($"d3 {d3}");
            Console.WriteLine($"d4 {d4}");
            d3 = d1 + d2;
            Console.WriteLine($"d3 {d3}");
            d3 = d1 + 7800;
            Console.WriteLine($"d3 {d3}");
            d3 = 666 + d1;
            Console.WriteLine($"d3 {d3}");
            d3 = d1++;
            Console.WriteLine($"d3 {d3}");
            Console.WriteLine($"d1 {d1}");
            d3 = --d2;
            Console.WriteLine($"d3 {d3}");
            Console.WriteLine($"d2 {d2}");
            if (d1 > d2)
            {
                Console.WriteLine("d1 bigger");
            }
            if (d1 <= d2)
            {
                Console.WriteLine("d1 smaller or equal");
            }
            DateTime obj = (DateTime)d1;
            Console.WriteLine($"date time hour {obj.Hour} Date time Min {obj.Minute} Date time Sec {obj.Second}");
        }
    }
}
