using Microsoft.AspNetCore.Identity;

namespace Social_Media.Models;

public class ApplicationUser : IdentityUser
{
    public string? DisplayName { get; set; }
    public string? PhotoUrl { get; set; }
    public string? About { get; set; }
    public int? Age { get; set; }
    public string? Likes { get; set; }
    public string? FavoriteFood { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

    public ICollection<Photo> Photos { get; set; } = new List<Photo>();
    public ICollection<Message> MessagesReceived { get; set; } = new List<Message>();
    public ICollection<Message> MessagesSent { get; set; } = new List<Message>();
}