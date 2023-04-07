using Microsoft.EntityFrameworkCore;
using Tasks.EF_Core.Dbo;

namespace Tasks.EF_Core.Context
{
    public class TasksContext : DbContext
    {
        public TasksContext(DbContextOptions<TasksContext> options) : base(options)
        {
        }

        public DbSet<BoardDbo> Boards { get; set; }

        public DbSet<ItemDbo> Items { get; set; }
        
        public DbSet<TokenDbo> Tokens { get; set; }

        public DbSet<UserDbo> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Tasks_Angular.db");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardDbo>().ToTable("Boards");
            modelBuilder.Entity<ItemDbo>().ToTable("Items");
            modelBuilder.Entity<TokenDbo>().ToTable("Tokens");
            modelBuilder.Entity<UserDbo>().ToTable("Users");

            modelBuilder.Entity<TokenDbo>()
                        .HasOne(x => x.User)
                        .WithOne()
                        .HasForeignKey<TokenDbo>(x => x.UserId);


            modelBuilder.Entity<ItemDbo>()
                        .HasOne(x => x.CreatedBy)
                        .WithOne()
                        .HasForeignKey<ItemDbo>(x => x.CreatedById);

            modelBuilder.Entity<ItemDbo>()
                        .HasOne(x => x.AssignedTo)
                        .WithOne()
                        .HasForeignKey<ItemDbo>(x => x.AssignedToId);

            modelBuilder.Entity<ItemDbo>()
                        .HasOne(x => x.Board)
                        .WithMany(x => x.Items)
                        .HasForeignKey(x => x.BoardId);

            modelBuilder.Entity<ItemDbo>()
                        .HasOne(x => x.ParentItem)
                        .WithOne()
                        .HasForeignKey<ItemDbo>(x => x.ParentItemId);

            modelBuilder.Entity<ItemDbo>()
                        .HasMany(x => x.SubItems)
                        .WithOne();


            modelBuilder.Entity<BoardDbo>()
                        .HasOne(x => x.Owner)
                        .WithOne()
                        .HasForeignKey<BoardDbo>(x => x.OwnerId);

            //TODO: add m:m 
            modelBuilder.Entity<BoardDbo>()
                        .HasMany(x => x.SharedUsers);

            modelBuilder.Entity<BoardDbo>()
                        .HasMany(x => x.Items)
                        .WithOne(x => x.Board);
        }
    }
}
