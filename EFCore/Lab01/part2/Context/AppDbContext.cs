using EF01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Context
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AO030L3\\SQLEXPRESS;Database=AppContext2;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasOne(s => s.Department).WithMany(d=>d.Students).HasForeignKey(s => s.DepartmentId);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }
}
