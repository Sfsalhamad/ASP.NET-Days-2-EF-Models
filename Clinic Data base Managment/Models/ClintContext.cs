using Clinic_Data_base_Managment.Helpers;
using Clinic_Data_base_Managment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clinic_Data_base_Managment
{
    public class ClintContext : IdentityDbContext<IdentityUser>
    {
        // Add constructor for DI
        public ClintContext(DbContextOptions<ClintContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Appointment> Appointments => Set<Appointment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>()
                .HasKey(d => d.id);

            modelBuilder.Entity<Doctor>()
                .Property(d => d.specilaty)
                .HasColumnType("nvarchar(100)");

            modelBuilder.Entity<Doctor>()
                .HasData(
                    new Doctor { id = 1, name = "Dr. Smith", specilaty = "Cardiology", description = "Heart Problems" },
                    new Doctor { id = 2, name = "Dr. Jones", specilaty = "Neurology", description = "Neurons Problems" }
                );

            // Fix: Replace DateTime.Now with a static date
            modelBuilder.Entity<Appointment>()
                .HasData(new Appointment
                {
                    id = 1,
                    patientName = "John Doe",
                    doctorName = "Dr. Smith",
                    appointmentDate = new DateTime(2024, 12, 25, 10, 0, 0) // Static date instead of DateTime.Now.AddDays(1)
                });

            // Identity table configurations
            modelBuilder.Entity<IdentityUser>(b => b.ToTable("Users"));
            modelBuilder.Entity<IdentityRole>(b => b.ToTable("Roles"));
            modelBuilder.Entity<IdentityRoleClaim<string>>(b => b.ToTable("RoleClaims"));
            modelBuilder.Entity<IdentityUserClaim<string>>(b => b.ToTable("UserClaims"));
            modelBuilder.Entity<IdentityUserRole<string>>(b => b.ToTable("UserRoles"));
            modelBuilder.Entity<IdentityUserToken<string>>(b => b.ToTable("UserTokens"));
            modelBuilder.Entity<IdentityUserLogin<string>>(b => b.ToTable("UserLogins"));

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "7f04c9e3-ed37-4f63-88cf-b512b6fd61f6", ConcurrencyStamp = "7f04c9e3-ed37-4f63-88cf-b512b6fd61f6", Name = AppRoles.Admin.ToString(), NormalizedName = AppRoles.Admin.ToString().ToUpper() },
                new IdentityRole { Id = "2c23dff5-efc4-4e34-945f-1a2f29da0231", ConcurrencyStamp = "2c23dff5-efc4-4e34-945f-1a2f29da0231", Name = AppRoles.Receptionist.ToString(), NormalizedName = AppRoles.Receptionist.ToString().ToUpper() },
                new IdentityRole { Id = "59fa9387-3202-4e97-aa7f-22a107c6e4a1", ConcurrencyStamp = "59fa9387-3202-4e97-aa7f-22a107c6e4a1", Name = AppRoles.Doctor.ToString(), NormalizedName = AppRoles.Doctor.ToString().ToUpper() }
            );
        }
    }
}
