using DurationProgram;

Duration d1 = new Duration(1,20,4);
Duration d2 = new Duration(1, 3, 20);
Duration d3 = new Duration(1, 20, 4);

Console.WriteLine(d1);

d3=d1 + d2;
Console.WriteLine(d3);

d3 = d1 + 5000;
Console.WriteLine(d3);

d3 = 5000 + d1;
Console.WriteLine(d3);
if(d1>d2)
{
	Console.WriteLine("d1 is bigger");
}

if(d2<d1)
{
	Console.WriteLine("d2 is smaller");
}

if (d3 <= d1)
{
	Console.WriteLine("d3 is <= d1");
}


DateTime obj = new DateTime();
obj=(DateTime)d1;

Console.WriteLine(obj);

