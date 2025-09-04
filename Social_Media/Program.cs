using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Social_Media.Components;
using Social_Media.Data;
using Social_Media.Models;
using Social_Media.Components.Pages; // for App

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(opts =>
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Identity
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
    {
        options.Password.RequiredLength = 10;
        options.Password.RequireNonAlphanumeric = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireLowercase = true;
        options.Password.RequireDigit = true;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddRazorPages();                 // Identity UI
builder.Services.AddRazorComponents()            // Blazor app
    .AddInteractiveServerComponents();
builder.Services.AddAntiforgery(); 

var app = builder.Build();

// Seed roles/users
using (var scope = app.Services.CreateScope())
{
    await Seed.EnsureSeedAsync(scope.ServiceProvider);
}

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseAntiforgery(); // needed for Identity forms

app.MapRazorPages(); // Identity endpoints
app.MapControllers();
app.MapRazorComponents<App>() 
    .AddInteractiveServerRenderMode();

app.Run();