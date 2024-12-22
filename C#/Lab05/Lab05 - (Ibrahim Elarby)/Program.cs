namespace c_day6lab
{
     class Program
    {
        static void Main(string[] args)
        {
            #region early binding
            Parent p = new Child();
            Parent p2 = new SubChild();
            Child c = new SubChild();
            p.showme();
            p2.showme();
            c.showme();
            #endregion
            #region late binding
            Parentl pl = new Childl();
            Parentl p2l = new SubChildl();
            Childl cl = new SubChildl();
            pl.showme();
            p2l.showme();
            cl.showme();
            #endregion

            #region static sum of areas v1
            Rectangler[] rectanglers = { new Rectangler(5, 3), new Rectangler(10, 3), new Rectangler(4, 5) };
            Square[] squares = { new Square(5), new Square(10) };
            double sumofareav1 = Utililty.sumofAreav1(rectanglers, squares);
            Console.WriteLine($"the sum of areas are {sumofareav1}");
            #endregion
            #region static sum of areas v2
            Shape[] shapes = { new Rectangler(5, 3), new Rectangler(10, 3), new Rectangler(4, 5) , new Square(5),new Square(10),new Triangle(3,2) , new Circle(7) };            
            double sumofareav2 = Utililty.sumofAreav2(shapes);
            Console.WriteLine($"the sum of areas are {sumofareav2}");
            #endregion
        }
    }
}
