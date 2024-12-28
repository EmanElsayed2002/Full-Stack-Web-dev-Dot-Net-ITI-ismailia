namespace Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Duration D2 = new Duration(7800);
            Duration D3 = new Duration(3600);
            Console.WriteLine(D2.ToString()); 
            
            Console.WriteLine(D3.ToString());
            if (D3 < D2) { Console.WriteLine("larger than"); }
            
            if (D2 > D3) { Console.WriteLine("less than"); }

            Duration D4 = new Duration(3600);
            
            Duration D5 = new Duration(3600);
            Console.WriteLine(D4.ToString());
            Console.WriteLine(D5.ToString());
            if (D4 >= D5) { Console.WriteLine("equal "); }
            if (D4 <= D5) { Console.WriteLine("equal "); }
        }
    }
}
