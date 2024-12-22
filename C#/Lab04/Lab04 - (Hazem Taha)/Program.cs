namespace C__day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab Assignments
            //1- implement dynamic Stack **
            //////static counter  **
            ///2-Implement Queue with any way shift , circular 
            ///3-class geoshape and its childs
            #endregion

            #region dynamic Stack 
            //DynamicStack s1 = new DynamicStack(7);
            //s1.Push(10);
            //s1.Push(10);
            //s1.Push(10);
            //s1.Push(10);




            #endregion

            #region Queue
            Queue q1 = new Queue(5);
            q1.EnQueue(10);
            q1.DeQueue();
            q1.EnQueue(20);
            q1.EnQueue(30);
            q1.EnQueue(40);
            q1.EnQueue(50);
            q1.DeQueue();

            q1.EnQueue(60);


            q1.Print();

            #endregion

            #region Geo sahpe
            Squer s=new Squer(5);
            Console.WriteLine(s.CalculateArea());

            Console.WriteLine("test");
            Console.WriteLine("!!");

            #endregion


        }
    }
}
