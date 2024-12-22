namespace C__day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region one employee read and write
            //Employee e1 = new Employee();
            //Console.WriteLine("Enter Id");
            //e1.SetId(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter Name");
            //e1.SetName(Console.ReadLine());
            //Console.WriteLine("Enter Age");
            //e1.SetAge(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Enter Salary");
            //e1.SetSalary(decimal.Parse(Console.ReadLine()));
            //e1.Print();
            #endregion
            //////////////////////

            #region  three employees read and write
            //Employee[] employees=new Employee[3];

            //for (int i = 0; i < employees.Length; i++)
            //{

            //    employees[i] = new Employee();
            //    Console.WriteLine($"Enter Id for employee {i}");
            //    employees[i].SetId(int.Parse(Console.ReadLine()));
            //    Console.WriteLine($"Enter Name for employee {i}");
            //    employees[i].SetName(Console.ReadLine());
            //    Console.WriteLine($"Enter Age for employee {i}");
            //    employees[i].SetAge(int.Parse(Console.ReadLine()));
            //    Console.WriteLine($"Enter Salary for employee {i}");
            //    employees[i].SetSalary(decimal.Parse(Console.ReadLine()));
            //}
            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[i].Print());
            //}
            #endregion
            ///////////////////
             #region class Complex
            Complex c1 =new Complex();
            Complex c2 = new Complex();
            Complex c3 = new Complex();
            while (true)
            {

                Console.WriteLine("Enter real num1");
                c1.SetReal(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter img num1");
                c1.SetImg(int.Parse(Console.ReadLine()));


                Console.WriteLine("Enter real num2");
                c2.SetReal(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter img num2");
                c2.SetImg(int.Parse(Console.ReadLine()));

                c3 = c1.Add(c2);

                Console.WriteLine($"the result: {c3.Print()}");
            }
            #endregion 

        }
    }
}
