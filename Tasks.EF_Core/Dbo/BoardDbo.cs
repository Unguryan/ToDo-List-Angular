using System.ComponentModel.DataAnnotations;

namespace Tasks.EF_Core.Dbo
{
    public class BoardDbo
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int OwnerId { get; set; }

        public UserDbo Owner { get; set; }

        public List<UserDbo>? SharedUsers { get; set; }

        public List<ItemDbo>? Items { get; set; }
    }
}
