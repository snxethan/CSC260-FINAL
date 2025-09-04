namespace Social_Media.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string FromUserId { get; set; } = default!;
        public ApplicationUser FromUser { get; set; } = default!;
        public string ToUserId { get; set; } = default!;
        public ApplicationUser ToUser { get; set; } = default!;
        public string Body { get; set; } = default!;
        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    }
}
