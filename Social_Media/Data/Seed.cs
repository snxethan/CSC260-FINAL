using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Social_Media.Models;

namespace Social_Media.Data;

public static class Seed
{
    public static async Task EnsureSeedAsync(IServiceProvider sp)
    {
        var um = sp.GetRequiredService<UserManager<ApplicationUser>>();
        var rm = sp.GetRequiredService<RoleManager<IdentityRole>>();

        const string adminRole = "Admin";
        if (!await rm.RoleExistsAsync(adminRole))
            await rm.CreateAsync(new IdentityRole(adminRole));

        var adminEmail = "email@email.com";
        var admin = await um.FindByEmailAsync(adminEmail);
        if (admin is null)
        {
            admin = new ApplicationUser()
            {
                UserName = "admin",
                Email = adminEmail,
                EmailConfirmed = true,
                DisplayName = "Site Admin"
            };
            await um.CreateAsync(admin, "Admin!Passw0rd");
            await um.AddToRoleAsync(admin, adminRole);
        }
    }
}