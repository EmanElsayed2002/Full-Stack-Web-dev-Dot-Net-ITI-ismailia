namespace CS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Late Binding
            Parent p1 = new Parent();
            Parent p2 = new Child();
            Parent p3 = new Subclass();
            Child p4  = new Child();
            Child p5  = new Subclass();

            p1.show();
            p2.show(); // display show function on Child class so this called Late Binding
            p3.show(); // display show function on SubClass class so this called Late Binding
            p4.show(); // display show function on Child class so this called Late Binding
            p5.show(); // display show function on SubClass class so this called Late Binding


            #endregion
        }
    }
}
