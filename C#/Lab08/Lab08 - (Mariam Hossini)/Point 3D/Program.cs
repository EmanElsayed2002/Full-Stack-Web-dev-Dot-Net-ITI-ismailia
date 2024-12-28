namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2 POINTS

            string result;
            _3DPoint p = new _3DPoint(10, 10, 10);
            Console.WriteLine(p.ToString());
            result =(string) p;
            Console.WriteLine(result);

            #endregion
            #region 2&3 points
            int numberOfPoints;
            int coordinate;
            bool test = false;
            Console.Write("Enter the number of points: ");
            numberOfPoints = int.Parse(Console.ReadLine());
            _3DPoint[] points = new _3DPoint[numberOfPoints];
            for (int i = 0; i < points.Length; i++) { 

                points[i] = new _3DPoint();
                do {
                    Console.Write($"Enter the X coordinate of p{i+1}:");
                     
                    if (int.TryParse(Console.ReadLine(), out coordinate)) 
                    { points[i].X = coordinate; 
                        test = true; }
                    else {
                        
                        Console.WriteLine("Enter a valid coordinate!!!!");
                    }
                }
                while (test == false);

                do
                {
                    test =false;
                    Console.Write($"Enter the Y coordinate of p{i + 1}:");
                    
                    if (int.TryParse(Console.ReadLine(), out coordinate)) {
                        points[i].Y = coordinate; 
                        test = true; }
                    else
                    {
                        
                        Console.WriteLine("Enter a valid coordinate!!!!");
                    }
                }
                while (test == false);

                do
                {
                    test =false;
                    Console.Write($"Enter the Z coordinate of p{i + 1}:");
                     
                    if (int.TryParse(Console.ReadLine(), out coordinate)) { 
                        points[i].Z = coordinate; 
                        test = true; }
                    else
                    {
                        Console.WriteLine("Enter a valid coordinate!!!!");
                    }
                }
                while (test == false);
            }
            for (int i = 0; i < points.Length; i++) {
                Console.WriteLine( $"Point{i+1}:-" );
                Console.WriteLine( points[i].ToString() );
            }
            #endregion
        }
    }
}
