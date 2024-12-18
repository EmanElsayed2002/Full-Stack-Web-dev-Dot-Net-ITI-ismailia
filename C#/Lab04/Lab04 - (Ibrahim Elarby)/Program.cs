using System.Formats.Asn1;

namespace c_day5lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicStack<int> intstack = new DynamicStack<int>();
            intstack.push(1);
            intstack.push(2);
            intstack.push(3);
            intstack.push(4);
            intstack.pop();
            intstack.print();
            intstack.push(5);
            intstack.pop();
            intstack.pop();
            intstack.pop();
            intstack.print();
            intstack.pop();
            intstack.print();
            intstack.pop();
            intstack.print();
            intstack.pop();
            intstack.print();


          
            DynamicQueue<int> queue = new DynamicQueue<int>(3);
            queue.enqueue(1);
            queue.enqueue(2);
            queue.enqueue(3);
            queue.print();
            queue.enqueue(4);
            queue.dequeue();
            queue.print();
            queue.dequeue();
            queue.enqueue(5);

            queue.print();
            queue.dequeue();
            queue.print();
            queue.dequeue();
            queue.print();

            Rectangler rectangler = new Rectangler(5,4);
            Circle circle = new Circle(7);
            Square square = new Square(3);
            Console.WriteLine(rectangler.area());
            Console.WriteLine(square.area());
            Console.WriteLine(circle.area());


          

        }
    }
}
