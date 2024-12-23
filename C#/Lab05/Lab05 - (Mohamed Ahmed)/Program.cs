namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static binding
            //Parent parent = new Child();
            //parent.Show1();

            //Parent parent2 = new SubChild();
            //parent2.Show1();

            //Child child = new SubChild();
            //child.Show1();
            #endregion


            #region Dynamic binding
            //Parent parent1 = new Child();
            //parent1.Show();

            //Parent parent2 = new SubChild();
            //parent2.Show();

            //Child child1 = new SubChild();
            //child1.Show();
            #endregion


            #region SumAreaWithLateBinding
            //GeoShape[] geoshapes =
            //{
            //    new Rectangle(2,4),
            //    new Rectangle(4,5),
            //    new Square(3),
            //    new Square(3),
            //};
            //Console.WriteLine(Utility.SumOfAreasWithLateBinding(geoshapes));
            #endregion



            #region SumAreas
            //Square[] squares = { new Square(5), new Square(5) };

            //Triangle[] triangles = { new Triangle(3, 4), new Triangle(5, 6) };

            //Console.WriteLine(Utility.SumOfAreas(triangles, squares));
            #endregion



        }
    }
}
