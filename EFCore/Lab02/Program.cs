using ITI.Context;
using ITI.Models;

namespace ITI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var track = new Track { Name = "Full Stack Development" };
                var department = new Department { Name = "Computer Science" };

                var student = new Student { FirstName = "Eman", LastName = "Elsayed", Age = 22, Track = track };
                context.Tracks.Add(track);
                context.Departments.Add(department);
                context.Students.Add(student);
                context.SaveChanges();

            }
        }
    }
}
