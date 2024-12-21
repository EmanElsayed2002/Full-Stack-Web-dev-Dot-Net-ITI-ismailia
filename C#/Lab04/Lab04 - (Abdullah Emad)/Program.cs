using LAB_4;

Queue Q1=new Queue(3);
Q1.Enqueue(1);
Q1.Enqueue(2);
Q1.Enqueue(3);


Console.WriteLine(Q1.Dequeue());
Console.WriteLine(Q1.Dequeue());

Q1.Enqueue(5);
Q1.Enqueue(6);
Console.WriteLine(Q1.Dequeue());
Console.WriteLine(Q1.Dequeue());
Console.WriteLine(Q1.Dequeue());

