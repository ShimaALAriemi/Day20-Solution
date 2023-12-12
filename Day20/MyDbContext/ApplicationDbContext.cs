using Day20.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20.MyDbContext
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-ISH7TNU; Initial Catalog=MakeenDay_20; Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Development>()
                .Property(m => m.Name).IsRequired();
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Development> Developments { get; set; }

    }
}
