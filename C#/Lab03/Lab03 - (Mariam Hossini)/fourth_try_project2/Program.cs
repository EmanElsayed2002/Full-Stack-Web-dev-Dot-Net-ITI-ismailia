namespace fourth_try_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //association
            #region PROJECT2 association
            //Emplyee e1 = new Emplyee();
            //HireDate hireDate = new HireDate();
            //Department department = new Department();
            //Console.Write("Enter the name of the Emplyee: ");
            //e1.SetName(Console.ReadLine());
            //Console.Write("Enter the ID of the Emplyee: ");
            //e1.SetId(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Age of the Emplyee: ");
            //e1.SetAge(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Salary of the Emplyee: ");
            //e1.SetSalary(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Hire date day of the Emplyee: ");
            //hireDate.SetDay(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Hire date month of the Emplyee: ");
            //hireDate.SetMonth(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the Hire date year of the Emplyee: ");
            //hireDate.SetYear(int.Parse(Console.ReadLine()));
            //e1.SetHireDate(hireDate);
            //Console.Write("Enter the name of Department of the Emplyee: ");
            //department.SetDeptName(Console.ReadLine());
            //Console.Write("Enter the Department ID of the Emplyee: ");
            //department.SetDeptId(int.Parse(Console.ReadLine()));
            //e1.SetDepartment(department);



            //Console.WriteLine("========================Reading Daat=======================");
            //Console.WriteLine($"Emplyee Name: {e1.GetName()}");
            //Console.WriteLine($"Emplyee ID: {e1.GetId()}");
            //Console.WriteLine($"Emplyee Age: {e1.GetAge()}");
            //Console.WriteLine($"Emplyee Salary: {e1.GetSalary()}");
            //Console.WriteLine($"Emplyee HireDate : {e1.GetHireDate().GetDay()} - {e1.GetHireDate().GetMonth()} - {e1.GetHireDate().GetYear()}");
            //Console.WriteLine($"Emplyee Department Name: {e1.GetDepartment().GetDeptName()}");
            //Console.WriteLine($"Emplyee Department ID: {e1.GetDepartment().GetDeptId()}");

            #endregion

            #region PROJECT3 association
            Emplyee[] employees = new Emplyee[2];
            HireDate[] hiredates = new HireDate[2];
            Department[] departments = new Department[2];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Emplyee();
                hiredates[i] = new HireDate();
                departments[i] = new Department();
                Console.Write($"Enter the name of the Emplyee no.{i + 1}: ");
                employees[i].SetName(Console.ReadLine());
                Console.Write($"Enter the ID of the Emplyee no.{i + 1}: ");
                employees[i].SetId(int.Parse(Console.ReadLine()));
                Console.Write($"Enter the Age of the Emplyee no.{i + 1}: ");
                employees[i].SetAge(int.Parse(Console.ReadLine()));
                Console.Write($"Enter the Salary of the Emplyee no.{i + 1}: ");
                employees[i].SetSalary(int.Parse(Console.ReadLine()));
                Console.Write($"Enter the Hire date day of the Emplyee no.{i + 1}: ");
                hiredates[i].SetDay(int.Parse(Console.ReadLine()));
                Console.Write($"Enter the Hire date month of the Emplyee no.{i + 1}: ");
                hiredates[i].SetMonth(int.Parse(Console.ReadLine()));
                Console.Write($"Enter the Hire date year of the Emplyee no.{i + 1}: ");
                hiredates[i].SetYear(int.Parse(Console.ReadLine()));
                employees[i].SetHireDate(hiredates[i]);
                Console.Write($"Enter the name of Department of the Emplyee no.{i + 1}: ");
                departments[i].SetDeptName(Console.ReadLine());
                Console.Write($"Enter the Department ID of the Emplyee no.{i + 1}: ");
                departments[i].SetDeptId(int.Parse(Console.ReadLine()));
                employees[i].SetDepartment(departments[i]);
            }

            Console.WriteLine("========================Reading Daat=======================");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Emplyee no.{i + 1} Name: {employees[i].GetName()}");
                Console.WriteLine($"Emplyee no.{i + 1} ID: {employees[i].GetId()}");
                Console.WriteLine($"Emplyee no.{i + 1} Age: {employees[i].GetAge()}");
                Console.WriteLine($"Emplyee no.{i + 1} Salary: {employees[i].GetSalary()}");
                Console.WriteLine($"Emplyee no.{i + 1} HireDate : {employees[i].GetHireDate().GetDay()} - {employees[i].GetHireDate().GetMonth()} - {employees[i].GetHireDate().GetYear()}");
                Console.WriteLine($"Emplyee no.{i + 1} Department Name: {employees[i].GetDepartment().GetDeptName()}");
                Console.WriteLine($"Emplyee no.{i + 1} Department ID: {employees[i].GetDepartment().GetDeptId()}");
            }
            #endregion
        }
    }
}