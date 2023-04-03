namespace Tasks.Domain.Models
{
    public class Board
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public User Owner { get; set; }

        public List<User> SharedUsers { get; set; }

        public List<ItemComposite> Items { get; set; }
    }
}
