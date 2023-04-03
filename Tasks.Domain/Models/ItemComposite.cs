namespace Tasks.Domain.Models
{

    public class ItemComposite
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ItemState State { get; set; }

        public List<ItemComposite> SubItems { get; set; }
    }
}
