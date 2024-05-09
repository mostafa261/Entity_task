using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .ToTable("NewTask");

         //   ''''''''''''''''''''''''''
            modelBuilder.Entity<Task>()
            .Property(b => b.data)
            .HasColumnName("Deadline");

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Elgohary;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
