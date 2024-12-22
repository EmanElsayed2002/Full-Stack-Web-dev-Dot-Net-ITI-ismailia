using CS;

namespace Static_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region static version1

            Circle[] circles = { new Circle(2), new Circle(3) };
            Rectangle[] rectangles = { new Rectangle(4, 5), new Rectangle(6, 7) };
            Traingle[] traingles = { new Traingle(3, 4), new Traingle(5, 6) };
            Console.WriteLine("Sum V1: " + Utility.SumOfShapesV1(circles, rectangles, traingles));


            #endregion
        }
       
    }
}
