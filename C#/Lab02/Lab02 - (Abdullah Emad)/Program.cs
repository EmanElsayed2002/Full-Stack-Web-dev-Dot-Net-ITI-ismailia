using ConsoleApp1;


#region Employee read and write
Employee e1 = new Employee();
HireDate hireDate = new HireDate();
Department department = new Department();

Console.WriteLine("Enter id");
e1.SetId(int.Parse(Console.ReadLine()));
Console.WriteLine("Enter name");
e1.SetName(Console.ReadLine());
Console.WriteLine("Enter age");
e1.SetAge(int.Parse(Console.ReadLine()));
Console.WriteLine("Enter salary");
e1.SetSalary(decimal.Parse(Console.ReadLine()));
Console.WriteLine("Enter Hire date");
hireDate.SetDate(DateOnly.Parse(Console.ReadLine()));
e1.SetHireDate(hireDate);
Console.WriteLine("Enter department name");
department.SetDeptName(Console.ReadLine());
e1.SetDepartment(department);
Console.WriteLine(e1.print());




#endregion
#region array of 3 employee
//Employee[] employees=new Employee[3];
//for (int i = 0; i < employees.Length; i++)
//{

//    employees[i] = new Employee();

//    Console.WriteLine("Enter Id");
//    employees[i].SetId(int.Parse(Console.ReadLine()));
//    Console.WriteLine("Enter Name");
//    employees[i].SetName(Console.ReadLine());
//    Console.WriteLine("Enter Age");
//    employees[i].SetAge(int.Parse(Console.ReadLine()));
//    Console.WriteLine("Enter Salary");
//    employees[i].SetSalary(decimal.Parse(Console.ReadLine()));
//}
#endregion
#region complex
//Complex c1 = new Complex();
//Complex c2 = new Complex();
//Complex c3 = new Complex();

//while (true)
//{

//	Console.WriteLine("Enter complex num1");

//	Console.WriteLine("Enter real");
//	c1.SetReal(int.Parse(Console.ReadLine()));
//	Console.WriteLine("Enter img");
//	c1.SetImg(int.Parse(Console.ReadLine()));

//	//Console.WriteLine("Enter complex num2");

//	//Console.WriteLine("Enter real");
//	//c2.SetReal(int.Parse(Console.ReadLine()));
//	//Console.WriteLine("Enter img");
//	//c2.SetImg(int.Parse(Console.ReadLine()));

//	string x = c1.Print();
//	Console.WriteLine();
//	Console.WriteLine($"{x}");
//	Console.WriteLine();
//}
#endregion



