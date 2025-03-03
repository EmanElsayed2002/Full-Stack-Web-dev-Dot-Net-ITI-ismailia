using LinqLab02.Models;

namespace LinqLab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            var employees = Repo.GetData.GetEmployee();
            var departs = Repo.GetData.Departments();
            #region 1.	First 4 Employees in the List Using Method Syntax [fluent syntax].
            //var q01 = employees.Take(4);
            //foreach (var item in q01)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2.	First 3 Employees in the List with Salary more than 5000 Using Method Syntax [fluent syntax].
            //var q02 = employees.Where(e => e.Salary > 5000);
            //foreach (var item in q02)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 3.	Last 4 Employees in the List Using Method Syntax [fluent syntax].
            //var q03 = employees.TakeLast(4);
            //foreach (var employee in q03)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion
            #region 4.	Second 2 Employees in the List Using Method Syntax [fluent syntax].
            //var q04 = employees.Skip(1).Take(2);
            //foreach (var employee in q04)
            //{
            //    Console.WriteLine(employee);
            //}
            #endregion
            #region 5.	All Employees While Name length < 5 Using Method Syntax [fluent syntax].
            //var q05 = employees.TakeWhile(e => e.Name.Length <= 5);
            //foreach (var item in q05)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 6.	Distinct Employees. Hint: (Using IEqualityComparer) Using Method Syntax [fluent syntax].
            //var q06 = employees.Distinct(new EmployeeComp());
            //foreach (var item in q06)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7.	Name and Id of All Employees Using Method Syntax [fluent syntax].
            //var q07 = employees.Select(e => new { Name = e.Name, Id = e.Id });
            //foreach (var item in q07)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 8.	Name and Id of All Employees Using Query Syntax.
            //var q08 = from emp in employees
            //          select new { emp.Id, emp.Name };
            //foreach (var item in q08)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 9.	Name and DeptName of All Employees Using Query Syntax.
            //var q09 = from emp in employees
            //          join dept in departs
            //          on emp.Id equals dept.Id
            //          select new { emp.Name, DeprtmentName =  dept.Name };
            //foreach (var item in q09)
            //{
            //    Console.WriteLine(item  );
            //}

            #endregion
            #region 10.	Name and DeptName of All Employees Using Method Syntax [fluent syntax].
            //var q10 = employees.Join(departs, emp => emp.Id, dept => dept.Id, (emp, dept) => new
            //{
            //    emp.Name, Departmant = dept.Name
            //});
            //foreach (var item in q10)
            //{
            //    Console.WriteLine( item);
            //}
            #endregion
            #region 11.	All Employees Group by DeptName Using Method Syntax [fluent syntax].
            //var q11 = employees.Join(departs, emp => emp.Id, dept => dept.Id, (emp, dept) => new
            //{
            //    EmployeeName = emp.Name,
            //    DepartmentName = dept.Name
            //}).GroupBy(x=> x.DepartmentName);
            //foreach (var item in q11)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}
            #endregion
            #region 12.	All Employees Group by DeptName Using Query Syntax.
            //var q12 = from emp in employees
            //          join dept in departs
            //          on emp.Id equals dept.Id
            //          group emp by dept.Name;
            //foreach (var item in q12)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }

            //}
            #endregion
            #region 13.	Min Salary, Max Salary, Avg Salary.
            //var q13 = employees.Max(x => x.Salary);
            //var q14 = employees.Min(x => x.Salary);
            //var q15 = employees.Average(x => x.Salary);
            //Console.WriteLine($"{q13} , {q14} , {q15}");
            #endregion
            #region 14.	Employee Where Salary < Avg Salary.
            //var q14 = employees.Where(emp => emp.Salary < employees.Average(emp => emp.Salary));
            //foreach (var item in q14)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 15.    Create two lists of int and try Expect, Concat, Union, Intersect.
            //var list1 = new List<int> { 1, 2, 3, 4, 5 };
            //var list2 = new List<int> { 1, 2, 3, 4, 5 };

            //var q1 = list1.Except(list2).ToList();
            //var q2 = list1.Concat(list2).ToList();
            //var q3 = list1.Union(list2).ToList();
            //var q4 = list1.Intersect(list2).ToList();


            #endregion
            #region 16.  Create list of Phone Number and Names and try Zip Operator
            //var phones = new List<string> { "1234567890" , "098765421" };
            //var names = new List<string> { "Eman", "Elsayed" };
            //var zipped = phones.Zip(names, (name, phone) => $"{phone} : {name}");
            //foreach (var item in zipped)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            


        }
    }
}
