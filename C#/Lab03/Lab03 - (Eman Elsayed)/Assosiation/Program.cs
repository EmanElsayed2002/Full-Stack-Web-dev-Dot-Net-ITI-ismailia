namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region - Create Constructor on Complex is Done 
            //Complex c1 = new Complex();
            //Console.WriteLine(c1.Print());
            //Complex c2 = new Complex(1 , 2);
            //Console.WriteLine(c2.Print());
            #endregion

            #region - Build Employee - Department - HireDate Classses Created Done
            //Employee employee = new Employee();
            //Department dept = new Department();
            //HireDate hireDate = new HireDate();
            #endregion

            #region - assosiation
            //Console.WriteLine("Welcome with Assosiation Relation:) ");
            //Console.WriteLine("Enter Emplyee SSN: ");
            //int ssn = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Emplyee Name: ");
            //string empName = Console.ReadLine();

            //Console.WriteLine("Enter Emplyee Age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Emplyee Department Name: ");
            //string deptName = Console.ReadLine();

            //Console.WriteLine("Enter Emplyee Department ID: ");
            //int deptId = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Emplyee Hire Day: ");
            //int hireDay = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Emplyee Hire Month: ");
            //int hireMonth = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Emplyee Hire Year: ");
            //int HireYear = int.Parse(Console.ReadLine());

            //Department dept = new Department(deptId, deptName);
            //HireDate hiredate = new HireDate(hireDay , hireMonth , HireYear);
            //Employee emp = new Employee(ssn , age , empName  );

            //Console.WriteLine(emp.Print(dept, hiredate));

            #endregion

            
            #region Third input Employee
            Employee[] employee = new Employee[3];
            Department[] dept = new Department[3];
            HireDate[] hiredate = new HireDate[3];
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine($"Enter Data For Employee#{i + 1}:");
                Console.WriteLine("Enter Emplyee SSN: ");
                int ssn = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Emplyee Name: ");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Emplyee Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Emplyee Department Name: ");
                string deptName = Console.ReadLine();

                Console.WriteLine("Enter Emplyee Department ID: ");
                int deptId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Emplyee Hire Day: ");
                int hireDay = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Emplyee Hire Month: ");
                int hireMonth = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Emplyee Hire Year: ");
                int HireYear = int.Parse(Console.ReadLine());

                dept[i] = new Department(deptId, deptName);
                hiredate[i] = new HireDate(hireDay, hireMonth, HireYear);
                employee[i] = new Employee(ssn, age, empName);
            }
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine($"Data Employee #{i + 1}");
                Console.WriteLine(employee[i].Print(dept[i], hiredate[i]));
                Console.WriteLine("-------------------------------------------");
            }
            #endregion
         
        }
    }
}
