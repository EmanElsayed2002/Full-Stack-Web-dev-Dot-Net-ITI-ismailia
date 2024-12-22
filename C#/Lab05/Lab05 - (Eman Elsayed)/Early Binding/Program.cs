namespace CS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Early Binding
            Parent p1 = new Parent();
            Parent p2 = new Child();
            Parent p3 = new Subclass();
            Child p4  = new Child();
            Child p5  = new Subclass();

            p1.show();
            p2.show(); // display show function on parent class so this called Early Binding
            p3.show();
            p4.show();  // display show function on Child class so this called Early Binding
            p5.show();


            #endregion
        }
    }
}
