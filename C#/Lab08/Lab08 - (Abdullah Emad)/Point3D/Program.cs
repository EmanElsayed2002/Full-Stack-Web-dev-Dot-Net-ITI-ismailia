using Lab08;

#region two point read and write
Point3D p1 = new Point3D();
Point3D p2 = new Point3D();
Console.WriteLine("Enter coordinates for first point");
Console.WriteLine("Enter X coordinates");
p1.X = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinates for first point");
Console.WriteLine("Enter Y coordinates");
p1.Y = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinates for first point");
Console.WriteLine("Enter Z coordinates");
p1.Z = int.Parse(Console.ReadLine());
int num;
Console.WriteLine("Enter coordinates for second point");
Console.WriteLine("Enter X coordinates");
if (int.TryParse(Console.ReadLine(), out num))
{
	p2.X = num;
}
else
{
	Console.WriteLine("Not Valid");
}
Console.WriteLine("Enter coordinates for second point");
Console.WriteLine("Enter Y coordinates");
if (int.TryParse(Console.ReadLine(), out num))
{
	p2.Y = num;
}
else
{
	Console.WriteLine("Not Valid");
}
Console.WriteLine("Enter coordinates for second point");
Console.WriteLine("Enter Z coordinates");
if (int.TryParse(Console.ReadLine(), out num))
{
	p2.Z = num;
}
else
{
	Console.WriteLine("Not Valid");
}

Console.WriteLine(p1);
Console.WriteLine(p2);
string str = null;
str = (string)p1;
Console.WriteLine(str);
#endregion


