using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CS_Day08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num of Employees: ");
            int n = int.Parse(Console.ReadLine());
            Employee[] Employees = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Employees[i] = new Employee();
                Console.WriteLine("Enter Eployee ID: ");
                Employees[i].ID = int.Parse(Console.ReadLine());
                bool flg = true;
                do
                {

                    Console.WriteLine("Enter Eployee Name: ");
                    Employees[i].Name = Console.ReadLine();
                    if (Employees[i].Name is null)
                    {
                        Console.WriteLine("Name Must be not null!!");
                        continue;
                    }
                    else if (Employees[i].Name.Length > 15)
                    {
                        Console.WriteLine("max lenght 15 char!!");
                        continue;

                    }
                    else if (Employees[i].Name.Contains(' '))
                    {
                        Console.WriteLine("Name must  not include spaces!!");
                        continue;

                    }

                    else if (!Regex.IsMatch(Employees[i].Name, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Name must only include chars!!");
                        continue;
                    }
                    flg = false;
                } while (flg);

                Console.WriteLine("Enter Eployee Salary: ");
                Employees[i].Salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Eployee Gender: 1-> Male    2-> Female  ");
                Employees[i].Gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine()) - 1;
                var hireD = new HiringDate();
                Console.WriteLine("Enter Eployee HireDate:  \nDay: ");
                hireD.Day = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Month: ");
                hireD.Month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Year:");
                hireD.Year = int.Parse(Console.ReadLine());
                Employees[i].HiringDate = hireD;
                Console.WriteLine("Enter Eployee securityLevel: Guest,\n2->Developer,\n3->Secretary,\n4->DBA");
                Employees[i].SecurityLevel = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine()) - 1;
            }
            Console.WriteLine("------------");
            foreach (var item in Employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
