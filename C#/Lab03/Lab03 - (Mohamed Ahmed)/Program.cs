using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region composition
            // composition
            //Employee emp1 = new Employee(123,"Mohamed", 33, 1,"CS",1,1,2024);

            //Console.WriteLine(emp1.Print()); 
            #endregion


            #region aggregation/association

            //Department department = new Department(1,"cs");
            //HireDate date = new HireDate(1,1,2022);

            //Employee employee = new Employee();

            //employee.SetDepartment(department);
            //employee.SetHireDate(date);

            //Console.WriteLine(employee.Print());



            //Department department = new Department(1,"cs");
            //HireDate date = new HireDate(1,1,2022); 
            #endregion


            #region Read from user aggregation/association

            //Department department = new Department(1, "cs");
            //HireDate date = new HireDate(1, 1, 2022);

            //Console.WriteLine("please enter ssn");
            //int Essn = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter name");
            //string Ename = Console.ReadLine();

            //Console.WriteLine("please enter age");
            //int Eage = int.Parse(Console.ReadLine());

            //Employee employee1 = new Employee(Essn, Ename, Eage, department, date);

            //employee1.SetDepartment(null);
            //employee1.SetHireDate(null);

            //Console.WriteLine(employee1.Print());
            #endregion


            #region Read from user composition
            //// composition  

            //Console.WriteLine("please enter ssn");
            //int Essn = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter name");
            //string Ename = Console.ReadLine();

            //Console.WriteLine("please enter age");
            //int Eage = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter department id");
            //int deptId = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter department name");
            //string deptName = Console.ReadLine();

            //Console.WriteLine("please enter hire day");
            //int day = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter hire month");
            //int month = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter hire year");
            //int year = int.Parse(Console.ReadLine());

            //Employee employee1 = new Employee(Essn, Ename, Eage, deptId, deptName, day, month, year);

            //Console.WriteLine(employee1.Print()); 
            #endregion



            #region 3 employee aggregation/association
            //Department department = new Department(1,"cs");
            //HireDate date = new HireDate(1,1,2022);

            //Employee[] employees = new Employee[3];

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    employees[i] = new Employee();

            //    Console.WriteLine("Please enter your ssn");
            //    int ssn = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Please enter your name");
            //    string name = Console.ReadLine();

            //    Console.WriteLine("Please enter your age");
            //    int age = int.Parse(Console.ReadLine());

            //    employees[i] = new Employee(ssn, name, age, department, date);

            //}

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].Print());
            //} 
            #endregion


            #region 3 employee composition
            //Employee[] employees = new Employee[3];

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    employees[i] = new Employee();

            //    Console.WriteLine("Please enter your ssn");
            //    int ssn = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Please enter your name");
            //    string name = Console.ReadLine();

            //    Console.WriteLine("Please enter your age");
            //    int age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("please enter department id");
            //    int deptId = int.Parse(Console.ReadLine());

            //    Console.WriteLine("please enter department name");
            //    string deptName = Console.ReadLine();

            //    Console.WriteLine("please enter hire day");
            //    int day = int.Parse(Console.ReadLine());

            //    Console.WriteLine("please enter hire month");
            //    int month = int.Parse(Console.ReadLine());

            //    Console.WriteLine("please enter hire year");
            //    int year = int.Parse(Console.ReadLine());

            //    Console.WriteLine("****************************");
            //    employees[i] = new Employee(ssn, name, age, deptId, deptName, day, month, year);

            //}

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].Print());
            //    Console.WriteLine("***********");
            //} 
            #endregion

        }
    }
}
