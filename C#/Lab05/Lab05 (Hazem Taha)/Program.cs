namespace C_Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab Assignments
            ///Try
            ///class Parent ,child ,subchild
            ///1-Early
            ///2-late

            ///3- geoshape 
            //////static SumOfAreasV1
            //////static SumOfAreasV2
            #endregion


            #region Late Binding 
            ParentLate P = new ParentLate();
            ParentLate P1 = new ChildLate();
            ParentLate P2 = new subChildLate();

            P.Show();
            P1.Show();
            P2.Show();
            #endregion
            Console.WriteLine("____________________________");

            #region Early Binding 
            Parent pp = new Parent();
            Parent PP1 = new Child();
            Parent PP2 = new subChild();


            pp.Show();
            PP1.Show();
            PP2.Show();
            #endregion


            #region geoshape static 

            #region V1
            Squer[] c = new Squer[]
            {
                    new Squer(5),
                    new Squer(6),
                    new Squer(7)
            };

            Rectangel[] rs = new Rectangel[]
            {
                new Rectangel(10,20),
                new Rectangel(10,30),
            };

            Trinagle[] ts = new Trinagle[]
            {
                new Trinagle(10,20),
                new Trinagle(10,30),
                new Trinagle(10,40)
            };

            Console.WriteLine($"the sum of area V1: {Utility.SumV1(rs, c, ts)}");
            Console.WriteLine("-----------------------");
            #endregion

            #region V2
            GeoShape[] shapes = new GeoShape[]  
            {
                new Rectangel(5,5),
                new Rectangel(5,6),
                new Squer(100),
                new Squer(150),
                new Circel(4),
                new Circel(4),
                new Trinagle(5,6),
                new Circel(4)
            };

            Console.WriteLine($"the sum of area v2: {Utility.SumV2(shapes)}");
            #endregion

            #endregion

        }
    }
}
