using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__day4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region one Employee  Try Composition
            
            Employee e1=new Employee();
            Console.Write("Enter SSN for Employee number 1: ");
            e1.SetSnn(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Name for Employee number 1: ");
            e1.setName(Console.ReadLine());
            Console.WriteLine("Enter Age for Employee number 1: ");
            e1.setAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Dpartment Id for Employee number 1: ");
            e1.SetDeparmentId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Dpartment Name for Employee number 1: ");
            e1.SetDpartmentName(Console.ReadLine());
            Console.WriteLine("Enteer Day of HireDay for Employee number 1: ");
            e1.SetHiredateDay(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enteer Month of HireDay for Employee number 1: ");
            e1.SetHiredateMonth(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enteer year of HireDay for Employee number 1: ");
            e1.SetHiredateYear(int.Parse(Console.ReadLine()));

            Console.WriteLine(e1.Print());
            Console.WriteLine("##############################");
            #endregion
            #region Three Employee 

            Employee[] employees = new Employee[3];
            for (int i = 0; i < 3; i++)

            {
                Department d =new Department();
                Hiredate h = new Hiredate();
                employees[i] = new Employee();
                Console.Write($"Enter SSN for Employee number {i+1}: ");
                employees[i].SetSnn(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Enter Name for Employee number {i+1}: ");
                employees[i].setName(Console.ReadLine());
                Console.WriteLine($"Enter Age for Employee number {i+1}: ");
                employees[i].setAge(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Enter Dpartment Id for Employee number {i+1}: ");
                d.SetDeptId(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Enter Dpartment Name for Employee number {i+1}: ");
                d.SetDeptName(Console.ReadLine());
                employees[i].SetDepartment(d);
                Console.WriteLine($"Enteer Day of HireDay for Employee number {i+1}: ");
                h.SetDay(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Enteer Month of HireDay for Employee number {i+1}: ");
                h.SetMonth(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Enteer year of HireDay for Employee number {i+1}: ");
                h.SetYear(int.Parse(Console.ReadLine()));
                employees[i].SetHiredate(h);
                Console.WriteLine("-----------------------------");


            }

            for(int i=0;i<employees.Length;i++)
            {
                Console.WriteLine(employees[i].Print());
                Console.WriteLine("------");
            }

            #endregion


        }
    }
}
