using CS;

namespace Static_v2
{
    internal class Program
    {
        #region static version2 
        
        static void Main(string[] args)
        {
           
            GeoShape[] shapes = { new Circle(2), new Circle(3), new Rectangle(4, 5), new Rectangle(6, 7), new Traingle(3, 4), new Traingle(5, 6) };

            Console.WriteLine("Sum V2: " + Utility.SumOfShapesV2(shapes));
        }
        #endregion
    }
}
