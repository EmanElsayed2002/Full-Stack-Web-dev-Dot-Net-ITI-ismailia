using LinqLab1.Models;
using System.Collections.Generic;

namespace LinqLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> students = Repo.GetData.Students();
            #region 1.Display all Student using LINQ Query Expression.
            //var q01 = from student in students
            //          select student;
            //foreach (var item in q01)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 2.	Display all Student using LINQ Method Syntax [fluent syntax].
            //var q02 = students;
            //foreach (var student in q02)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion
            #region 3.Display all Students with Age > 30 using LINQ Query Expression.
            //var q03 = from student in students
            //          where student.Age > 30
            //          select student;
            //foreach (var item in q03)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 4.	Display all Students with Salary < 5000 using LINQ Method Syntax [fluent syntax].
            //var q04 = students.Where(s => s.Salary < 5000);
            //foreach (var item in q04)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 5.	Display all Students with TrackId =1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.
            //var q05 = from student in students
            //          where student.TrackId == 1 && student.Salary > 4000
            //          let name = student.FirstName + " " + student.LastName
            //          orderby name descending
            //          select student;
            //foreach (var item in q05)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 6.	Display all Students with TrackId = 1 and first name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax [fluent syntax].
            //var q06 = students.Where(s => s.TrackId == 1 && s.FirstName.ToLower().Contains("m")).OrderBy(s => s.Salary).Select(s => new { FullName = s.FirstName + ' ' + s.LastName , Salary=s.Salary});
            //foreach (var item in q06)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region 7.	Find First Student with Salary more than 5000. 
            //// Hint: (using First and FirstOrDefault and Explain difference)
            //var q07 = students.FirstOrDefault(s => s.Salary > 5000);
            //Console.WriteLine(q07);
            #endregion
            #region  8.	Find Last Student in Track number 10.
            // Hint: (using Last and LastOrDefault and Explain difference)
            //var q08 = students.LastOrDefault(s => s.TrackId == 10);
            //Console.WriteLine(q08);
            #endregion
            #region 9.	Find Student with Age equal 25.
            //Hint: (using Single and SingleOrDefault and Explain difference)
            //var q09 = students.SingleOrDefault(s => s.Age == 25);
            //var q09 = students.Single(s => s.Age == 25);

            //Console.WriteLine(q09);
            #endregion
            #region 10.	Find Student with TrackId equal 8.
            // Hint: (using Single and SingleOrDefault and Explain difference)
            //var q10 = students.SingleOrDefault(s => s.TrackId == 8);
            //Console.WriteLine(q10);
            #endregion
            #region 11.	Find Student in index 4.
            //var q11 = students.ElementAtOrDefault(4);
            //Console.WriteLine(q11);
            #endregion
            #region FindStudentsSorted
            var list = students.ToList();
            FindStudentsSorted(list);
            #endregion

        }
         static void FindStudentsSorted(List<Student> students)
        {
            Console.WriteLine("Sort by (FName, LName, Age, Salary): ");
            string sortBy = Console.ReadLine();

            Console.WriteLine("Order (ASC or DESC): ");
            string sortOrder = Console.ReadLine().ToUpper();

            var sortedStudents = sortBy switch
            {
                "FName" => sortOrder == "ASC" ? students.OrderBy(s => s.FirstName) : students.OrderByDescending(s => s.FirstName),
                "LName" => sortOrder == "ASC" ? students.OrderBy(s => s.LastName) : students.OrderByDescending(s => s.LastName),
                "Age" => sortOrder == "ASC" ? students.OrderBy(s => s.Age) : students.OrderByDescending(s => s.Age),
                "Salary" => sortOrder == "ASC" ? students.OrderBy(s => s.Salary) : students.OrderByDescending(s => s.Salary)
                
            };

            Console.WriteLine("\nSorted Students:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - Age: {student.Age}, Salary: {student.Salary}");
            }
        }

       

    }
}
