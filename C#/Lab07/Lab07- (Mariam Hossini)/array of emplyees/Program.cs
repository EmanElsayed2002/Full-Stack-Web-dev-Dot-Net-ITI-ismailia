using System.Text.RegularExpressions;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool test = true;
            int length;
            Console.Write("Enter the number of Emplyees: ");
            length = int.Parse(Console.ReadLine()); 

            Emplyee[] e = new Emplyee[length];
            HireDate[] hireDate = new HireDate[length];
            for (int i = 0; i < e.Length; i++) 
            { 
                e [i] = new Emplyee();
                hireDate [i] = new HireDate();
                do
                {
                    test = true;
                    string pattern1 = @"^[a-zA-Z]+$";

                    Console.Write($"Enter the name of the emplyee no.{i+1}: ");
                    e[i].Name = Console.ReadLine();
                    if (!(Regex.IsMatch(e[i].Name, pattern1))) { test = false; }
                    if (test == false) { Console.WriteLine("Please enter valid name!!!!"); }
                }
                while (test == false);


                Console.Write($"Enter the ID of the emplyee no.{i+1}: ");
                e[i].Id = int.Parse(Console.ReadLine());


                Console.Write($"Enter the Salary of the emplyee no.{i+1}: ");
                e[i].Salary = int.Parse(Console.ReadLine());

                do
                {
                    string gen;
                    test = true;
                    Console.Write($"Enter the Gender of the emplyee no.{i+1}: ");
                    
                    gen = Console.ReadLine();
                    if (gen == "Male"||  gen == "Female") { test = true;
                        e[i].Gender = (Gender)Enum.Parse(typeof(Gender), gen);
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid gender!!!!");
                        test = false;
                    }
                }
                while (test == false);

                do
                {
                    test = true;
                    Console.Write($"Enter the Day of hiredate of the emplyee no.{i+1}: ");
                    hireDate[i].Day = int.Parse(Console.ReadLine());
                    if (hireDate[i].Day < 0 || hireDate[i].Day > 30) { test = false;
                        Console.WriteLine("Please enter valid Day!!!!");
                    }

                }
                while (test == false);


                do
                {
                    test = true;
                    Console.Write($"Enter the Month of hiredate of the emplyee no.{i+1}: ");
                    hireDate[i].Month = int.Parse(Console.ReadLine());
                    if (hireDate[i].Month < 0 || hireDate[i].Month > 12) { test = false;
                        Console.WriteLine("Please enter valid Month!!!!");
                    }

                }
                while (test == false);

                do
                {
                    test = true;
                    Console.Write($"Enter the Year of hiredate of the emplyee no.{i+1}: ");
                    hireDate[i].Year = int.Parse(Console.ReadLine());
                    if (hireDate[i].Year < 1999 || hireDate[i].Year > 2024) {
                        test = false;
                        Console.WriteLine("Please enter valid Year!!!!");
                    }

                }
                while (test == false);

                e[i].HireDate = hireDate[i];

                do
                {
                    test = true;
                    Console.Write($"Enter the Security Level of the emplyee no.{i+1}: ");

                    string str = Console.ReadLine();
                    switch (str)
                    {
                        case "guest":
                        
                        case "Developer":
                        case "Secretary":
                        case "DBA":
                            test = true;
                            e[i].SecurityLevel = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), str);
                            break;
                        default:
                            test = false;
                            Console.WriteLine("Please enter valid Security Level!!!!");

                            ; break;
                    }
                }
                while (test == false);

            }
            for (int k = 0; k < e.Length; k++) {
                Console.WriteLine($"The data of emplyee no.{k+1}:");
                string reslut = e[k].ToString();
                Console.WriteLine(reslut);
            }
        }
    }
}
