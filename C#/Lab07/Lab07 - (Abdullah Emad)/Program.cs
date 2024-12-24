using System.Text.RegularExpressions;
using Lab07;

bool flag = true;
#region one Employee
//Employee e1 = new Employee();
//HireDate hireDate;
//Console.WriteLine("Enter employee id");
//e1.Id =int.Parse(Console.ReadLine());

//do
//{
//	Console.WriteLine("Enter employee name");
//	e1.Name = Console.ReadLine();
//	if(e1.Name.Length>8)
//	{
//		flag = false;
//	}
//	else if(e1.Name==null)
//	{
//		flag = false;
//	}
//	else if(!(Regex.IsMatch(e1.Name, @"^[a-zA-Z]+$")))
//	{
//		flag = false;
//	}
//	else
//	{
//		flag = true;
//	}

//} while(flag==false);

//Console.WriteLine("Enter salary");
//e1.Salary = decimal.Parse(Console.ReadLine());
//Console.WriteLine("Enter Gender [male , female]");
//e1.G1 = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
//Console.WriteLine("Enter Security Level ");
//e1.SecurityLevel=(SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine());
//Console.WriteLine("Enter Hire day");
//e1.SetDay(int.Parse(Console.ReadLine()));
//Console.WriteLine("Enter Hire Month");
//e1.SetMonth(int.Parse(Console.ReadLine()));
//Console.WriteLine("Enter Hire Year");
//e1.SetYear(int.Parse(Console.ReadLine()));

//Console.WriteLine(e1); 
#endregion








#region Array of 3 Employees
Employee[] EmpArr = new Employee[3];
for (int i = 0; i < EmpArr.Length; i++)
{

	EmpArr[i] = new Employee(); // def ctor
	Console.WriteLine($"Enter employee {i + 1} id");
	EmpArr[i].Id = int.Parse(Console.ReadLine());

	do
	{
		Console.WriteLine($"Enter employee {i + 1} name");
		EmpArr[i].Name = Console.ReadLine();
		if (EmpArr[i].Name.Length > 8)
		{
			flag = false;
		}
		else if (EmpArr[i].Name == null)
		{
			flag = false;
		}
		else if (!(Regex.IsMatch(EmpArr[i].Name, @"^[a-zA-Z]+$")))
		{
			flag = false;
		}
		else
		{
			flag = true;
		}

	} while (flag == false);

	Console.WriteLine("Enter salary");
	EmpArr[i].Salary = decimal.Parse(Console.ReadLine());
	string str=null;
	do
	{
		Console.WriteLine("Enter Gender");
		str= Console.ReadLine();
		if (str!="male" && str!="female")
		{
			flag = false;
		}
		else
		{
			flag = true;
		}

	} while (flag == false);
	EmpArr[i].G1 = (Gender)Enum.Parse(typeof(Gender), str);
	do
	{
		Console.WriteLine("Enter Security Level");
		str = Console.ReadLine();
		if(str != "guest" && str != "developer" && str != "secretary" && str != "DBA")
		{
			flag=false;
		}
		else
		{
			flag = true;
		}
	} while (flag == false);
	
	EmpArr[i].SecurityLevel = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), str);
	Console.WriteLine("Enter Hire day");
	EmpArr[i].SetDay(int.Parse(Console.ReadLine()));
	Console.WriteLine("Enter Hire Month");
	EmpArr[i].SetMonth(int.Parse(Console.ReadLine()));
	Console.WriteLine("Enter Hire Year");
	EmpArr[i].SetYear(int.Parse(Console.ReadLine()));

	Console.WriteLine(EmpArr[i]);
} 
#endregion

