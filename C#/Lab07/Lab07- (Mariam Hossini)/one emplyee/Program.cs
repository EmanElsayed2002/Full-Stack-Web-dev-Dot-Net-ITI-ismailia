using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Ttask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Employee
            bool test = true;
            Emplyee e1 =new();
            HireDate hireDate = new HireDate();
            do {
                test = true;
                string pattern1 = @"^[a-zA-Z]+$";

                Console.Write("Enter the name of the emplyee: ");
                e1.Name = Console.ReadLine();
                if (!(Regex.IsMatch(e1.Name, pattern1))) { test = false; }
                if (test == false) { Console.WriteLine("Please enter valid name!!!!"); }
            }
            while (test == false);


            Console.Write("Enter the ID of the emplyee: ");
            e1.Id = int.Parse(Console.ReadLine());


            Console.Write("Enter the Salary of the emplyee: ");
            e1.Salary = int.Parse(Console.ReadLine());

            do {
                string gen;
                test = true;
                Console.Write("Enter the Gender of the emplyee: ");
               
                gen = Console.ReadLine  ();
                if (gen == "Male" ||gen == "Female" ) { test = true;
                    e1.Gender = (Gender)Enum.Parse(typeof(Gender), gen);
                }
                else {
                    Console.WriteLine("Please enter valid gender!!!!");
                    test = false; }
            }
            while (test==false);

            do
            {
                test = true;
                Console.Write("Enter the Day of hiredate of the emplyee: ");
                hireDate.Day = int.Parse(Console.ReadLine());
                if (hireDate.Day < 0 || hireDate.Day > 30)
                {
                    test = false;
                    Console.WriteLine("Please enter valid Day!!!!");
                }


            }
            while (test == false);


            do {
                test = true;
                Console.Write("Enter the Month of hiredate of the emplyee: ");
                hireDate.Month = int.Parse(Console.ReadLine());
                if (hireDate.Month < 0 || hireDate.Month > 12)
                {
                    test = false;
                    Console.WriteLine("Please enter valid Month!!!!");
                }

            }
            while (test == false);

            do {
                test = true;
                Console.Write("Enter the Year of hiredate of the emplyee: ");
                hireDate.Year = int.Parse(Console.ReadLine());
                if (hireDate.Year < 1999 || hireDate.Year > 2024) { test = false;
                    Console.WriteLine("Please enter valid Year!!!!");
                }
               

            }
            while (test == false);

            e1.HireDate = hireDate;

            do {
                test = true;
                Console.Write("Enter the Security Level of the emplyee: ");
                string str = Console.ReadLine();
                switch (str) {
                    case "guest":

                    case "Developer":
                    case "Secretary":
                    case "DBA":
                        test = true;
                        e1.SecurityLevel = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), str);
                        break;
                    default:test = false;
                        Console.WriteLine("Please enter valid Security Level!!!!");

                        ; break;
                }
            }
            while(test == false);

            Console.WriteLine("===========================");

            string reslut = e1.ToString();
            Console.WriteLine(reslut);
            #endregion

        }
    }
}
