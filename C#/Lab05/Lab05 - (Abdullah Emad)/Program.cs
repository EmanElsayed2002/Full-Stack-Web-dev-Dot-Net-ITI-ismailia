
using Lab05;
//trying early binding/late binding
Parent p1 = new Child();
p1.Show();

Child c1=new SubChild();
c1.Show();


//SumOfAreas V1,V2  
Rectangle[] rarr={new Rectangle(3,4),new Rectangle(5,6)};
Square[] sarr = {new Square(3),new Square(4)};

Console.WriteLine(Utility.SumOfAreasV1(rarr,sarr));


Geoshape[] garr = {new Rectangle(3,4),new Rectangle(5,6),new Square(3),
	                                         new Square(4)};

Console.WriteLine(Utility.SumOfAreasV2(garr));
