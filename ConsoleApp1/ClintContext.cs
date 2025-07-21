using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClintContext : DbContext
    {
        public DbSet<Doctor> Doctors => Set<Doctor>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=Clinic;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>()
                .HasKey(d => d.id);

            modelBuilder.Entity<Doctor>()
                .HasMany(d => d.Appointments)
                .WithOne(a => a.doctor)
                .HasForeignKey(a => a.doctorId);

            modelBuilder.Entity<Doctor>()
                .Property(d => d.specilaty)
                .HasColumnType("nvarchar(100)");

            modelBuilder.Entity<Doctor>()
                .HasData(
                    new Doctor { id = 1, name = "Dr. Smith", specilaty = "Cardiology" },
                    new Doctor { id = 2, name = "Dr. Jones", specilaty = "Neurology" }
                );


        }
 
    }
}
