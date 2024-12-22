namespace _05_Fifth_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================TASK1=========================");
            #region EARLY BINDING
            ParentE p1 = new ParentE("mariam", 1);
            Console.WriteLine(p1.Show());
            ParentE p2 = new ChildE("mariam", 1, 24);
            Console.WriteLine(p2.Show());
            ParentE p3 = new SubChildE("mariam", 1, 24, "female");
            Console.WriteLine(p3.Show());
            #endregion

            Console.WriteLine("\n\n======================TASK2=========================");
            #region LATE BINDING
            ParentL p4 = new ParentL("mariam", 1);
            Console.WriteLine(p4.Show());
            ParentL p5 = new ChildL("mariam", 1, 24);
            Console.WriteLine(p5.Show());
            ParentL p6 = new SubChildL("mariam", 1, 24, "female");
            Console.WriteLine(p6.Show());

            #endregion

            Console.WriteLine("\n\n======================TASK3=========================");
            Square[] squares = new Square[2];
            Rectangle[] rectangles = new Rectangle[2];
            squares[0] = new Square(3, 3);
            squares[1] = new Square(4, 4);
            rectangles[0] = new Rectangle(3, 4);
            rectangles[1] = new Rectangle(5, 6);
            Console.Write("Area verson1 = ");
            Console.WriteLine(GetAreas.SumOfAreasV1(squares, rectangles));

            GeoShape[] geoshapes = { new Square(3,3) , new Square(4,4) , new Rectangle(3,4),
            new Rectangle(5,6)};

            Console.Write("Area verson2 = ");
            Console.WriteLine(GetAreas.SumOfAreasV2(geoshapes));
        }
    }
}

