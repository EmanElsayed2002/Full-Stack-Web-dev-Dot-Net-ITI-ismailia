namespace try_third
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region read write emplyee
            //Emplyee e1 = new Emplyee();
            //Console.Write("Enter the name of the emplyee: ");
            //e1.SetName(Console.ReadLine());

            //Console.Write("Enter the id of the emplyee: ");
            //e1.SetId(int.Parse(Console.ReadLine()));

            //Console.Write("Enter the age of the emplyee: ");
            //e1.SetAge(int.Parse(Console.ReadLine()));

            //Console.Write("Enter the salary of the emplyee: ");
            //e1.SetSalary(int.Parse(Console.ReadLine()));

            //Console.WriteLine("===========================================================\n");
            //Console.WriteLine($"The emplyee name is : {e1.GetName()}");
            //Console.WriteLine($"The emplyee Id is : {e1.GetId()}");
            //Console.WriteLine($"The emplyee age is : {e1.GetAge()}");
            //Console.WriteLine($"The emplyee salary is : {e1.GetSalary()}");
            #endregion

            #region 3Emplyee
            Emplyee[] emplyees = new Emplyee[3];
            for (int i = 0; i < emplyees.Length; i++)
            {
                emplyees[i] = new Emplyee();

                Console.Write($"Enter the name of emplyee no.{i + 1}: ");
                emplyees[i].SetName(Console.ReadLine());

                Console.Write($"Enter the id of emplyee no.{i + 1}: ");
                emplyees[i].SetId(int.Parse(Console.ReadLine()));

                Console.Write($"Enter the age of emplyee no.{i + 1}: ");
                emplyees[i].SetAge(int.Parse(Console.ReadLine()));

                Console.Write($"Enter the salary of emplyee no.{i + 1}: ");
                emplyees[i].SetSalary(int.Parse(Console.ReadLine()));

            }
            Console.WriteLine("==================================================================\n");
            for (int i = 0; i < emplyees.Length; i++)
            {
                Console.WriteLine($"The name of emplyee no.{i + 1} : {emplyees[i].GetName()}");
                Console.WriteLine($"The ID of emplyee no.{i + 1} : {emplyees[i].GetId()}");
                Console.WriteLine($"The Age of emplyee no.{i + 1} : {emplyees[i].GetAge()}");
                Console.WriteLine($"The salary of emplyee no.{i + 1} : {emplyees[i].GetSalary()}");
            }
            #endregion

            #region real imagine
            //Complex c1 = new Complex();
            //Complex c2 = new Complex();
            //Complex c3 = new Complex();
            //string result;
            //Console.Write("Enter the real of the first number: ");
            //c1.SetReal(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the imagine of the first number: ");
            //c1.SetImag(int.Parse(Console.ReadLine()));
            //result = c1.print();
            //Console.WriteLine(result);



            //Console.Write("Enter the real of the second number: ");
            //c2.SetReal(int.Parse(Console.ReadLine()));
            //Console.Write("Enter the imagine of the second number: ");
            //c2.SetImag(int.Parse(Console.ReadLine()));


            //result = c2.print();
            //Console.WriteLine(result);
            //Console.WriteLine("===========================adding==========");
            //c3=c1.add(c2);
            //result = c3.print();
            //Console.WriteLine(result);
            #endregion
        }
    }
}