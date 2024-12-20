namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            //MyStack myStack = new MyStack(3);
            //myStack.Push(1);
            //myStack.Push(2);
            //myStack.Push(3);


            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());

            //Console.WriteLine($"Counter: { MyStack.GetCounter()}"); 
            #endregion

            #region Queue
            MyQueue myQueue = new MyQueue(4);

            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);

            Console.WriteLine(myQueue.Dequeue());

            myQueue.Enqueue(6);

            Console.WriteLine("****");
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());

            #endregion

            //Rectangle rectangle = new Rectangle(10, 5);
            //Console.WriteLine(rectangle.Area());

            //Square square = new Square(5);
            //Console.WriteLine(square.Area());

            //Circle circle = new Circle(2);
            //Console.WriteLine(circle.Area());

            //Triangle triangle = new Triangle(2,2);
            //Console.WriteLine(triangle.Area());
        }
    }
}
