namespace Social_Media.Models;

public class Photo
{
    public int Id { get; set; }
    public string UserId { get; set; } = default!;
    public ApplicationUser User { get; set; } = default!;
    public string Url { get; set; } = default!;
    public string? Caption { get; set; }
    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
}