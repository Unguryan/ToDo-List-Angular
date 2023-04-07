using System.ComponentModel.DataAnnotations;

namespace Tasks.EF_Core.Dbo
{
    public class UserDbo
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? TelegramId { get; set; }

        public string? GitHubUserName { get; set; }

        public string? Username { get; set; }

    }
}
