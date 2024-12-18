namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region - Implement Dynamic stack
            //DynamicStack ds = new DynamicStack();
            //ds.Push(1);
            //ds.Push(2);
            //ds.Push(3);
            //ds.Push(4);
            //ds.Push(5);
            //ds.Pop();
            //ds.Pop();
            //Console.WriteLine($"IsArray Empty!! => {ds.isEmpty()}");
            //Console.WriteLine($"IsArray Full!! => {ds.isFull()}");
            //Console.WriteLine($"Size Of Stack is => {ds.Size()}");
            //Console.WriteLine($"Top Element is => {ds.GetTop()}");
            //ds.Print();
            #endregion

            #region - Implement Queue using Array shift , Circular
            //Queue q = new Queue(10);
            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //q.Enqueue(5);
            //q.Enqueue(6);
            //q.Print();
            //q.Dequeue();
            //q.Dequeue();
            //q.Dequeue();
            //q.Print();
            //Console.WriteLine($"Is Queue Empty => {q.isEmpty()}");
            //Console.WriteLine($"Is Queue Full => {q.isFull()}");
            //Console.WriteLine($"Is Queue Full => {q.isFull()}");
            //Console.WriteLine($"Front Of Queue => {q.GetFront()}");

            //CircularQueue cq = new CircularQueue();
            //cq.Enqueue(1);
            //cq.Enqueue(2);
            //cq.Enqueue(3);
            //cq.Enqueue(4);
            //cq.Enqueue(5);
            //cq.Dequeue();
            //cq.Dequeue();
            //cq.Dequeue();
            //Console.WriteLine($"Is Queue Empty => {cq.isEmpty()}");
            //Console.WriteLine($"Is Queue Full => {cq.isFull()}");
            //Console.WriteLine($"Is Queue Full => {cq.isFull()}");
            //Console.WriteLine($"Front Of Queue => {cq.GetFront()}");
            //cq.Print();


            #endregion

            #region - Class Geoshape and its Child
            Circle c = new Circle(5);
            Console.WriteLine(c.CArea());
            Traingle t = new Traingle(5 , 4);
            Console.WriteLine(t.CArea());
            Rectangle r = new Rectangle(4, 3);
            Console.WriteLine(r.CArea());
            Squre s = new Squre(4);
            Console.WriteLine(s.CArea());
            Console.WriteLine();
            Console.WriteLine();
            #endregion

        }
    }
}
