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

            #region - Try Aggregation
            Console.WriteLine("Welcome with Aggregation Relation:) ");
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

            Department dept = new Department(deptId, deptName);
            HireDate hiredate = new HireDate(hireDay , hireMonth , HireYear);
            Employee emp = new Employee(ssn , age , empName  );
            emp.SetDept(dept);
            emp.SetHireDate(hiredate);
            Console.WriteLine(emp.Print());
            #endregion
            
        }
    }
}
