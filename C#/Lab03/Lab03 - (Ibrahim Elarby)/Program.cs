namespace c_day4lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department web = new Department(1, "web development");
            Department ui = new Department(2, "UI/UX");
          
            int k = 3;
            
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "Ibrahim", 25, 20000, "male", web, 1, 12, 2024);

            for (int i = 1; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                Console.WriteLine($"Employee number {i} enter your Id");
                employees[i].setId(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Employee number {i} enter your Name");
                employees[i].setName(Console.ReadLine());
                Console.WriteLine($"Employee number {i} enter your salary");
                employees[i].setSalary(decimal.Parse(Console.ReadLine()));
                Console.WriteLine($"Employee number {i} enter your Age");
                employees[i].setAge(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Employee number {i} enter your Gender");
                employees[i].setGender(Console.ReadLine());
                Console.WriteLine($"Employee number {i} enter your Department web or ui");
                string temp = Console.ReadLine();
                if (temp == "web")
                {
                    employees[i].setDepartment(web);
                }
                else if (temp == "ui")
                {
                    employees[i].setDepartment(ui);
                }
                else
                {
                    Console.WriteLine("if not what is your department");
                    Department dep = new Department(k++, Console.ReadLine());
                    employees[i].setDepartment(dep);
                }

                Console.WriteLine($"Employee number {i} enter your hiredate day");
                employees[i].setHireDateday(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Employee number {i} enter your hiredate month");
                employees[i].setHireDatemonth(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Employee number {i} enter your hiredate year");
                employees[i].setHireDateyear(int.Parse(Console.ReadLine()));

            }
            for (int i = 0; i < employees.Length; i++)
            {
                {
                    Console.WriteLine(employees[i].print());
                }

            }
        }
    }
}
