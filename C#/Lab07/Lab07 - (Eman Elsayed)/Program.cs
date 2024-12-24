using System.Text.RegularExpressions;

namespace lab09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plz Enter No of Employee To Entered: ");
            int n = int.Parse(Console.ReadLine());
            Employee[] emp = new Employee[n];
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                emp[i] = new Employee();
                emp[i]._Id = i;
                do
                {

                    Console.Write($"Plz Enter Employee[#{i + 1}] Name: ");
                    emp[i]._Name = Console.ReadLine();
                    flag = Regex.IsMatch(emp[i]._Name, @"^[a-zA-Z]+$");
                }
                while (flag != true);

                Console.Write($"Plz Enter Employee[#{i + 1}] Security Levels: ");

                emp[i]._SecureLevels = (SecurityLevels)Enum.Parse(typeof(SecurityLevels), Console.ReadLine());
                Console.Write($"Plz Enter Employee[#{i + 1}] Salary: ");
                emp[i]._Salary = decimal.Parse(Console.ReadLine());
                Console.Write($"Plz Enter Employee[#{i + 1}] Hiredate: day: ");
                int day = int.Parse(Console.ReadLine());
                Console.Write($"Plz Enter Employee[#{i + 1}] Hiredate: Month: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write($"Plz Enter Employee[#{i + 1}] Hiredate: Year: ");
                int year = int.Parse(Console.ReadLine());
                emp[i].SetEmployeeHireDate(day, month, year);
                Console.Write($"Plz Enter Employee[#{i + 1}] Gender: ");
                emp[i]._Gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------");
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(emp[i].ToString());
            }
        }
    }
}
