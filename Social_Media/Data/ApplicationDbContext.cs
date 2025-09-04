using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Social_Media.Models;

namespace Social_Media.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Message> Messages => Set<Message>();
    public DbSet<Photo> Photos => Set<Photo>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        base.OnModelCreating(b);

        b.Entity<Message>()
            .HasOne(m => m.FromUser)
            .WithMany(u => u.MessagesSent)
            .HasForeignKey(m => m.FromUserId)
            .OnDelete(DeleteBehavior.Restrict);

        b.Entity<Message>()
            .HasOne(m => m.ToUser)
            .WithMany(u => u.MessagesReceived)
            .HasForeignKey(m => m.ToUserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
