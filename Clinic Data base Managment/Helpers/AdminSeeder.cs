using Microsoft.AspNetCore.Identity;

namespace Clinic_Data_base_Managment.Helpers
{
    public static class AdminSeeder
    {
        public static async Task CreateAdminUser(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // Create roles first
            await CreateRoles(roleManager);

            var adminEmail = "admin@clinic.com";
            var adminPassword = "Admin@123456";

            var admin = await userManager.FindByEmailAsync(adminEmail);
            if (admin == null)
            {
                admin = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(admin, adminPassword);
                if (!result.Succeeded)
                {
                    throw new Exception($"Failed to create admin user: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                }

                result = await userManager.AddToRoleAsync(admin, AppRoles.Admin.ToString());
                if (!result.Succeeded)
                {
                    throw new Exception($"Failed to add admin user to Admin role: {string.Join(", ", result.Errors.Select(e => e.Description))}");
                }
            }
        }

        private static async Task CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            foreach (var role in Enum.GetNames<AppRoles>())
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}