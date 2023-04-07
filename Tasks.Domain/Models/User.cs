namespace Tasks.Domain.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? TelegramId { get; set; }

        public string? GitHubUserName { get; set; }

        public string? Username { get; set; }
    }
}
