using EF01.Context;
using EF01.Models;
using Microsoft.EntityFrameworkCore;

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

                    new Student() {  Name = "Eman Elsayed" ,DepartmentId = depts[0].Id},
                    new Student() {  Name = "Hala Haitham"  , DepartmentId =  depts[0].Id},
                    new Student() {  Name = "Mona Ahmed" , DepartmentId =  depts[2].Id},
                    new Student() {  Name = "Alaa Reda" , DepartmentId =  depts[1].Id},
                    new Student() {  Name = "shrouk Ali"  , DepartmentId =  depts[3].Id},
                    new Student() {  Name = "Hagar Elsayed"  , DepartmentId =  depts[1].Id},
                    new Student() {  Name = "Ahmed Mohamed"  , DepartmentId =  depts[1].Id},
                    
                };

                context.AddRange(students);
                context.SaveChanges();
                //var studs = context.Students.ToList();
                //foreach (var item in studs)
                //{
                //    Console.WriteLine(item);
                //}
                //var depts = context.Departments.ToList();
                //foreach (var item in depts)
                //{
                //    Console.WriteLine(item);
                //}
                //var studentEagerLoading = context.Students.Include(students => students.Department).ToList();
                //foreach (var item in studentEagerLoading)
                //{
                //    Console.WriteLine($"{item.Name} {item.Department.Name}" );
                //}
                //var q1 = context.Students.Include(d => d.Department).Where(s=>s.DepartmentId == 1).ToList();
                //foreach (var item in q1)
                //{
                //    Console.WriteLine($"{item.Name} {item.Department.Name}");
                //}
                var q2 = context.Students.Where(s=> s.DepartmentId == 1).OrderByDescending(s=>s.Name).ToList();
                foreach (var item in q2)
                {
                    Console.WriteLine(item);
                }

            }
        }
    }
}
