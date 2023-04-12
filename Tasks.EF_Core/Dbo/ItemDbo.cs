using System.ComponentModel.DataAnnotations;
using Tasks.Domain.Models;

namespace Tasks.EF_Core.Dbo
{
    public class ItemDbo
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public ItemState State { get; set; }

        public int CreatedById { get; set; }
        public UserDbo CreatedBy { get; set; }

        public int? AssignedToId { get; set; }
        public UserDbo? AssignedTo { get; set; }

        public int BoardId { get; set; }
        public BoardDbo Board { get; set; }

        public int? ParentItemId { get; set; }
        public ItemDbo? ParentItem { get; set; }

        public List<ItemDbo>? SubItems { get; set; }
    }
}
