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
    }
}
