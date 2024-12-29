namespace Day10CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sort Array of employee

            //Employee[] employees =
            //{
            //    new Employee{ID=1,Name="Hazem",HiringDate=new HiringDate(10,10,2024),Salary=25000,SecurityLevel=SecurityLevel.Developer},
            //    new Employee{ID=2,Name="Moaz",HiringDate=new HiringDate(1,10,2024),Salary=25000,SecurityLevel=SecurityLevel.securityOfficer},
            //    new Employee{ID=3,Name="Ali",HiringDate=new HiringDate(1,5,2024),Salary=25000,SecurityLevel=SecurityLevel.DBA},
            //    new Employee{ID=4,Name="Sarah",HiringDate=new HiringDate(10,10,2023),Salary=25000,SecurityLevel=SecurityLevel.DBA},

            //};

            //Array.Sort(employees);

            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Try P1==P2 
            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = new Point3D(1, 2, 3);
            //Point3D P3 = new Point3D(5, 6, 7);
            //Console.WriteLine(P1 == P2);
            //Console.WriteLine(P1 == P3);

            #endregion

            #region  Try to override the Equals Function (from base Object) 
            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = new Point3D(1, 2, 3);
            //Point3D P3 = new Point3D(5, 6, 7);

            //Console.WriteLine(P1.Equals(P2));
            //Console.WriteLine(P1.Equals(P3));

            #endregion

            #region Sort Array Of Points3D
            //Point3D[] points =
            //    {new Point3D(1,2,3),
            //    new Point3D(2,3,3),
            //    new Point3D(1,5,3),
            //    new Point3D(1,5,7),
            //    new Point3D(1,4,3),
            //    new Point3D(1,5,10)};
            //Array.Sort(points);

            //foreach (var item in points)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Implement IClonable interface to be able to clone the object
            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = (Point3D)P1.Clone();

            //Console.WriteLine(P1);
            //Console.WriteLine(P1.GetHashCode());
            //Console.WriteLine(P2);
            //Console.WriteLine(P2.GetHashCode());

            #endregion

            #region GetHasCode
            //Point3D P1 = new Point3D(1, 2, 3);
            //Point3D P2 = new Point3D(2, 2, 3);

            //Console.WriteLine(P1.GetHashCode());
            //Console.WriteLine(P2.GetHashCode());


            #endregion
        }
    }
}
