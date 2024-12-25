using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Day09
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array of Employee
            //Employee[] employees;
            //Console.Write("Enter number of employees: ");
            //int n;
            //bool b = false;
            //do
            //{
            //    b = int.TryParse(Console.ReadLine(), out n);
            //    if (!b) { Console.WriteLine("Not Vaild Num"); }
            //}
            //while (!b);
            //employees = new Employee[n];


            //for (int i = 0; i < n; i++)
            //{
            //    employees[i] = new Employee();


            //    Console.WriteLine("Enter Eployee ID: ");
            //    bool flg = false;
            //    do
            //    {

            //        if (int.TryParse(Console.ReadLine(), out int idd))
            //        {
            //            employees[i].ID = idd;
            //            flg = true;
            //        }
            //        else
            //        { Console.WriteLine("Not Vaild Num"); }
            //    }
            //    while (!flg);
            //    flg = false;
            //    do
            //    {
            //        Console.WriteLine("Enter Eployee Name: ");
            //        employees[i].Name = Console.ReadLine();
            //        if (employees[i].Name is null)
            //        {
            //            Console.WriteLine("Name Must be not null!!");
            //            continue;
            //        }
            //        else if (employees[i].Name.Length > 15)
            //        {
            //            Console.WriteLine("max lenght 15 char!!");
            //            continue;

            //        }
            //        else if (employees[i].Name.Contains(' '))
            //        {
            //            Console.WriteLine("Name must  not include spaces!!");
            //            continue;

            //        }

            //        else if (!Regex.IsMatch(employees[i].Name, @"^[a-zA-Z]+$"))
            //        {
            //            Console.WriteLine("Name must only include chars!!");
            //            continue;
            //        }
            //        flg = false;
            //    } while (flg);


            //}

            #endregion

            #region  3D Point Class
            //Point3D p1 = new Point3D();
            //Point3D p2 = new Point3D();

            //Console.WriteLine("Enter the Coordinates for p1:");
            //bool bo = false;
            //int x, y,z;
            //do
            //{
            //    if (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.WriteLine("NOT Valid!!!");
            //    }
            //  else {
            //        p1.P1 = x;
            //        bo = true;
            //    }
            //}
            //while (!bo);
            //bo = false;
            //do
            //{
            //    if (!int.TryParse(Console.ReadLine(), out y))
            //    {
            //        Console.WriteLine("NOT Valid!!!");
            //    }
            //    else
            //    {
            //        p1.P2 = y;
            //        bo = true;
            //    }
            //}
            //while (!bo);
            //bo = false;
            //do
            //{
            //    if (!int.TryParse(Console.ReadLine(), out z))
            //    {
            //        Console.WriteLine("NOT Valid!!!");
            //    }
            //    else
            //    {
            //        p2.P3 = z;
            //        bo = true;
            //    }
            //}
            //while (!bo);

            /////////////////
            //Console.WriteLine("Enter the Coordinates for p2:");
            //do
            //{
            //    if (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.WriteLine("NOT Valid!!!");
            //    }
            //    else
            //    {
            //        p2.P1 = x;
            //        bo = true;
            //    }
            //}
            //while (!bo);
            //bo = false;
            //do
            //{
            //    if (!int.TryParse(Console.ReadLine(), out y))
            //    {
            //        Console.WriteLine("NOT Valid!!!");
            //    }
            //    else
            //    {
            //        p2.P2 = y;
            //        bo = true;
            //    }
            //}
            //while (!bo);
            //bo = false;
            //do
            //{
            //    if (!int.TryParse(Console.ReadLine(), out z))
            //    {
            //        Console.WriteLine("NOT Valid!!!");
            //    }
            //    else
            //    {
            //        p2.P3 = z;
            //        bo = true;
            //    }
            //}
            //while (!bo);


            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            #endregion

            #region array of 3D Point 

            //Point3D[] points=new Point3D[3];

            //for (int i = 0; i < points.Length; i++)
            //{
            //    points[i] = new Point3D();
            //    Console.WriteLine($"Enter the Coordinates for p{i+1}:");
            //    Console.WriteLine("Enter pooint x: ");
            //    bool bo = false;
            //    int x, y, z;
            //    do
            //    {
            //        if (!int.TryParse(Console.ReadLine(), out x))
            //        {
            //            Console.WriteLine("NOT Valid!!!");
            //        }
            //        else
            //        {
            //            points[i].P1 = x;
            //            bo = true;
            //        }
            //    }
            //    while (!bo);
            //    Console.WriteLine("Enter pooint y: ");
            //    bo = false;
            //    do
            //    {
            //        if (!int.TryParse(Console.ReadLine(), out y))
            //        {
            //            Console.WriteLine("NOT Valid!!!");
            //        }
            //        else
            //        {
            //            points[i].P2 = y;
            //            bo = true;
            //        }
            //    }
            //    while (!bo);
            //    bo = false;
            //    Console.WriteLine("Enter pooint z: ");
            //    do
            //    {
            //        if (!int.TryParse(Console.ReadLine(), out z))
            //        {
            //            Console.WriteLine("NOT Valid!!!");
            //        }
            //        else
            //        {
            //            points[i].P3 = z;
            //            bo = true;
            //        }
            //    }
            //    while (!bo);
            //}


            //foreach(var i in points)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region  Math class
            //int x, y;
            //Console.WriteLine("Enter 2 num: \n x:");
            //bool bo = false;
            //do
            //{
            //    if (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.WriteLine("NOT Valid!!!");
            //    }
            //    else
            //    {
            //        bo = true;
            //        Console.WriteLine("Enter Y:");
            //    }
            //}
            //while (!bo);


            //while (!int.TryParse(Console.ReadLine(), out y))
            //{         
            //       Console.WriteLine("NOT Valid!!!");

            //}



            //Console.WriteLine($"Add: {MyMath.Add(x, y)}");
            //Console.WriteLine($"Subtract: {MyMath.Subtract(x, y)}");
            //Console.WriteLine($"Multiply: {MyMath.Multiply(x, y)}");
            //Console.WriteLine($"Divide: {MyMath.Divide(x, y)}");
            #endregion

            #region FTP client 

            //FTP f1 = FTP.MyObj;
            //FTP f2 = FTP.MyObj;
            //FTP f3 = FTP.MyObj;

            //Console.WriteLine($"Manufacture:{f1.Manufacture}||MACAddress:{f1.MACAddress}||Type:{f1.TypeOf}");
            //Console.WriteLine($"Manufacture:{f2.Manufacture}||MACAddress:{f2.MACAddress}||Type:{f2.TypeOf}");
            //Console.WriteLine($"Manufacture:{f3.Manufacture}||MACAddress:{f3.MACAddress}||Type:{f3.TypeOf}");

            #endregion

            #region Duration  

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); 

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());


            D4++;
            Console.WriteLine(D4.ToString());
            
            D3--;
            Console.WriteLine(D3.ToString());
            
            if(D1>D2)
            {
                Console.WriteLine("D1>D2");
            }
            else
            {
                Console.WriteLine("D1<D2");
            }

            DateTime d=(DateTime)D1;

            Console.WriteLine(d.ToString());
            #endregion

        }
    }
}
