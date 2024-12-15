namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region - one employee read and write
            //Employee employee = new Employee();
            //Console.Write("Enter Employee ID: ");
            //employee.SetId(int.Parse(Console.ReadLine()));
            //Console.WriteLine();
            //Console.Write("Enter Employee Name: ");
            //employee.SetName(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Enter Employee Age: ");
            //employee.SetAge(int.Parse(Console.ReadLine()));
            //Console.WriteLine();
            //Console.Write("Enter Employee Salary: ");
            //employee.SetSalary(decimal.Parse(Console.ReadLine()));
            //Console.WriteLine();
            //Console.WriteLine(employee.Print());
            #endregion

            #region - three employees read and write
            //Employee[] Employees = new Employee[3];

            //for (int i = 0; i < Employees.Length; i++)
            //{
            //    Employees[i] = new Employee();
            //    Console.Write($"Enter Employee ID #{i + 1}: ");
            //    Employees[i].SetId(int.Parse(Console.ReadLine()));
            //    Console.WriteLine();
            //    Console.Write($"Enter Employee Name #{i + 1}: ");
            //    Employees[i].SetName(Console.ReadLine());
            //    Console.WriteLine();
            //    Console.Write($"Enter Employee Age #{i + 1}: ");
            //    Employees[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.WriteLine();
            //    Console.Write($"Enter Employee Salary #{i + 1}: ");
            //    Employees[i].SetSalary(decimal.Parse(Console.ReadLine()));
            //    Console.WriteLine("-------------------------------------");
            //}
            //for (int i = 0; i < Employees.Length; i++)
            //{
            //    Console.WriteLine($"Employee#{i + 1}");
            //    Console.WriteLine(Employees[i].Print());
            //}
            #endregion

            #region - class Complex real ,img ,setters ,getters ,print,Add
            char ch;
            do
            {
                Complex c1 = new Complex();
                Complex c2 = new Complex();
                Console.Write("Plz Enter Real number for complex one: ");
                c1.SetReal(int.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.Write("Plz Enter Img number for complex one: ");
                c1.SetImg(int.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.Write("Plz Enter Real number for complex Two: ");
                c2.SetReal(int.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.Write("Plz Enter Img number for complex Two: ");
                c2.SetImg(int.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.Write("Complex 1: ");
                Console.WriteLine(c1.Print());
                Console.WriteLine();
                Console.Write("Complex 2: ");
                Console.WriteLine(c2.Print());
                Complex sum = c1.Add(c2);
                Console.Write("Summation Two Complex: ");
                Console.WriteLine(sum.Print());
                Console.WriteLine("Do  You Want To Repeat Again (Y/N): ");
                ch = char.Parse(Console.ReadLine());
            } while (ch != 'y' || ch != 'Y');
            

            #endregion
        }
    }
}
