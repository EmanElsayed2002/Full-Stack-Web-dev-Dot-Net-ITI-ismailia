using EF01.Context;
using EF01.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Department[] depts = new Department[] {
                    new Department {  Name = "Information Technology" },
                    new Department { Name = "Human Resources" },
                    new Department { Name = "Marketing" },
                    new Department {  Name = "Accounting" },
                    new Department {  Name = "Engineering" }
                };
                context.AddRange(depts);
                context.SaveChanges();

                Student[] students = new Student[] {

                    new Student() {  Name = "Eman Elsayed",Age = 20,Salary = 1234 ,DepartmentId = depts[0].Id},
                    new Student() {  Name = "Hala Haitham" ,Age = 30,Salary = 3456 , DepartmentId =  depts[0].Id},
                    new Student() {  Name = "Mona Ahmed" ,Age = 40,Salary = 5432, DepartmentId =  depts[2].Id},
                    new Student() {  Name = "Alaa Reda",Age = 30 ,Salary = 9876, DepartmentId =  depts[1].Id},
                    new Student() {  Name = "shrouk Ali",Age = 23  ,Salary = 1234, DepartmentId =  depts[3].Id},
                    new Student() {  Name = "Hagar Elsayed" ,Age = 40 ,Salary = 2345, DepartmentId =  depts[1].Id},
                    new Student() {  Name = "Ahmed Mohamed",Age = 26 ,Salary = 3456 , DepartmentId =  depts[1].Id},

                };

                context.AddRange(students);
                context.SaveChanges();

                #region 1.	Display all Student using LINQ Query Expression
                //var q01 = context.Students.ToList();
                //foreach (var item in q01)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

                #region 2.	Display all Student using LINQ Method Syntax [fluent syntax].
                //var q02 = from s in students
                //          select s;
                //foreach(var item in q02)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

                #region 3.	Display all Students with Age > 30 using LINQ Query Expression
                //var q03 = from s in students
                //          where s.Age > 30
                //          select s;
                //foreach(var item in q03)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

                #region 4.	Display all Students with Salary < 5000 using LINQ Method Syntax [fluent syntax].
                //var q04 = students.Where(s => s.Salary < 5000);
                //foreach(var item in q04)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

                #region 5.	Display all Students with DepartmentId = 1 and salary > 4000 OrderBy Name descending using LINQ Query Expression.
                //var q06 = from s in students
                //          where s.DepartmentId == 1 && s.Salary > 4000
                //          orderby s.Name descending
                //          select s;
                //foreach(var item in q06)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion

                #region 6.	Display all Students with DepartmentId = 1 and Name Contains ‘m’ OrderBy Salary Ascending using LINQ Method Syntax [fluent syntax].
                //var q06 = students.Where(s => s.DepartmentId == 1 && s.Name.Contains("m")).OrderByDescending(s => s.Salary);
                //foreach(var item in q06)
                //{
                //    Console.WriteLine(item);
                //}
                #endregion
                #region 7.	Find First Student with Salary more than 5000. 
                // Hint: (using First and FirstOrDefault)
                var q07 = students.FirstOrDefault(s => s.Salary > 5000);
                Console.WriteLine(q07);
                #endregion
                #region 8.	Find Last Student in Department number 10.
                // Hint: (using Last and LastOrDefault)
                var q08 = students.Where(s => s.DepartmentId == 10).Last();
                Console.WriteLine(q08);
                #endregion
                #region 9.	Find Student with Age equal 25.
                // Hint: (using Single and SingleOrDefault)
                var q09 = students.SingleOrDefault(s => s.Age == 25);
                Console.WriteLine(q09);
                #endregion
                #region 10.	Find Student with DepartmentId equal 8.
                //  Hint: (using Single and SingleOrDefault)
                var q10 = students.SingleOrDefault(s => s.DepartmentId == 8);
                Console.WriteLine(q10);
                #endregion

            }
        }
    }
}