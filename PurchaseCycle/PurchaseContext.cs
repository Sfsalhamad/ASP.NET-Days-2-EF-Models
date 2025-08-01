using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PurchaseCycle
{
    public class PurchaseContext : DbContext
    {
        // This line will create a table in the database named "Purchases" with the properties defined in the Purchase class.
        public DbSet<Customer> Customer => Set<Customer>();
       // public DbSet<Product> Products => Set<Product>();
        //public DbSet<Order> Order => Set<Order>();



        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=PurchaseCycle;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Purchase>()
        //        .HasKey(p => p.Id);
        //    modelBuilder.Entity<Product>()
        //        .HasKey(p => p.Id);
        //    modelBuilder.Entity<Purchase>()
        //        .HasMany(p => p.Products)
        //        .WithOne(p => p.Purchase)
        //        .HasForeignKey(p => p.PurchaseId);
        //}
    }
}
