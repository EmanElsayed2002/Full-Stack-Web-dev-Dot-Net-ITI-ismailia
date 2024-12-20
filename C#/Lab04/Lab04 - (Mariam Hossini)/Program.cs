using System.Data;

namespace fifth_day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dynamic Stack
            //int data;
            //bool test = false;
            //Stack s1 = new Stack();
            //s1.Push(1);
            //s1.Push(2);
            //s1.Push(3);
            //s1.Push(4);
            //s1.Push(5);
            //s1.Push(6);
            //s1.Push(7);
            //s1.print();
            //test = s1.IsFull();
            //if (test)
            //{
            //    Console.WriteLine("Stack is Full");
            //}
            //data=s1.Pop();
            //Console.WriteLine(data);

            //data=s1.Pop();
            //Console.WriteLine(data);

            //data = s1.Pop();
            //Console.WriteLine(data);

            //data = s1.Pop();
            //Console.WriteLine(data);

            //data = s1.Pop();
            //Console.WriteLine(data);

            //data = s1.Pop();
            //data=s1.Pop();
            //test = s1.IsEmpty();
            //if (test)
            //{
            //    Console.WriteLine("Stack is Empty");
            //}

            //Console.WriteLine($"Number of stcks = {Stack.GetCounter()}");

            #endregion


            #region Queue
            //int data;
            //Queue q1 = new Queue();
            //bool resl;
            //q1.Enqueue(1);
            //q1.Enqueue(2);
            //q1.Enqueue(3);
            //q1.Enqueue(4);
            //q1.Enqueue(5);
            //q1.Enqueue(3);

            //data = q1.Dequeue();
            //Console.WriteLine(data);

            //data = q1.Dequeue();
            //Console.WriteLine(data);

            //data = q1.Dequeue();
            //Console.WriteLine(data);

            //data = q1.Dequeue();
            //Console.WriteLine(data);

            //data = q1.Dequeue();
            //Console.WriteLine(data);

            //data = q1.Dequeue();
            //Console.WriteLine(data);

            #endregion

            #region AREAS
            double area;
            Square s1 = new Square(2);

            Rectangle r1 = new Rectangle(5, 6);
            Triangle triangle = new Triangle(7, 8);
            area = s1.SuareArea();
            Console.WriteLine(area);
            area = r1.RectArea();
            Console.WriteLine(area);
            area = triangle.TriangleArea();
            Console.WriteLine(area);

            #endregion
        }
    }
}