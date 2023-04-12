using System.ComponentModel.DataAnnotations;

namespace Tasks.EF_Core.Dbo
{
    public class TokenDbo
    {
        [Key]
        public int Id { get; set; }

        public string? TokenData { get; set; }

        public DateTime ExpiredAt { get; set; }

        public int UserId { get; set; }

        public virtual UserDbo User { get; set; }
    }
}
