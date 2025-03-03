using ITI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Context
{
    public class AppDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-AO030L3\\SQLEXPRESS;Database=ITI_Simulate;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasKey(d => d.Id);

            modelBuilder.Entity<Department>().Property(d => d.Name).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Department>().HasMany(d => d.Students).WithOne();
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

    }
}
