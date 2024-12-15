namespace C_day3lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region employee
            /*    Employee[] employees = new Employee[3];
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine($"employee number {i + 1}");
                    employees[i] = new Employee();
                    employees[i].read();
                }
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine(employees[i].print());
                }*/
            #endregion
            #region complex
            Complex complex1 = new Complex();
            Complex complex2 = new Complex();
            complex1.read();
            complex2.read();
            Complex complex3 = new Complex();
            complex3 = complex1.add(complex2);
            Console.WriteLine(complex1.print());
            Console.WriteLine(complex2.print());
            Console.WriteLine(complex3.print());
            #endregion
        }
    }
}
