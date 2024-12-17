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

            #region - Try Composition


            //Console.WriteLine("Welcome with Composition Relation:) ");
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
            //int hireYear = int.Parse(Console.ReadLine());

            //Employee emp = new Employee(ssn, age, empName, deptId, deptName, hireDay, hireMonth, hireYear);


            //Console.WriteLine(emp.Print());

            #endregion

            #region Third input Employee
            Employee[] employee = new Employee[3];
            
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

                
                employee[i] = new Employee(ssn, age, empName , deptId ,deptName , hireDay , hireMonth , HireYear);
            }
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine($"Data Employee #{i + 1}");
                Console.WriteLine(employee[i].Print());
                Console.WriteLine("-------------------------------------------");
            }
            #endregion
        }
    }
}
