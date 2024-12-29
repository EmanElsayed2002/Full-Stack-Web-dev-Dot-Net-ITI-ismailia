namespace C_day9Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D[] points = new Point3D[3];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point3D();
                Console.WriteLine($"enter the x cordinates for point {i+1}");
                do
                {
                    if (double.TryParse(Console.ReadLine(), out double x))
                    {
                        points[i].X = x;
                        break;
                    }
                    Console.WriteLine("enter valid input");
                } while (true);
                Console.WriteLine($"enter the y cordinates for point {i+1}");
                do
                {
                    if (double.TryParse(Console.ReadLine(), out double y))
                    {
                        points[i].Y = y;
                        break;
                    }
                    Console.WriteLine("enter valid input");
                } while (true);
                Console.WriteLine($"enter the Z cordinates for point {i+1}");
                do
                {
                    if (double.TryParse(Console.ReadLine(), out double z))
                    {
                        points[i].Z = z;
                        break;
                    }
                    Console.WriteLine("enter valid input");
                } while (true);             

            }
            for (int i = 0; i < points.Length; i++)
            {
                //v1
                Console.WriteLine($"version1 point {i + 1} : {points[i]}");
                //v2
                string str = points[i];
                Console.WriteLine($"version2 point {i + 1} : {str}");

            }
        }
    }
}
