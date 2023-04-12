using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
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

            modelBuilder.Entity<BoardDbo>().HasKey(b => b.Id);
            modelBuilder.Entity<ItemDbo>().HasKey(b => b.Id);
            modelBuilder.Entity<TokenDbo>().HasKey(b => b.Id);
            modelBuilder.Entity<UserDbo>().HasKey(b => b.Id);

            modelBuilder.Entity<TokenDbo>()
                        .HasOne(x => x.User)
                        .WithOne()
                        .HasForeignKey<TokenDbo>(x => x.UserId);
            modelBuilder.Entity<TokenDbo>()
                        .Navigation(x => x.User)
                        .AutoInclude();


            modelBuilder.Entity<ItemDbo>()
                        .HasOne(x => x.CreatedBy)
                        .WithMany()
                        .HasForeignKey(x => x.CreatedById);
            modelBuilder.Entity<ItemDbo>()
                       .Navigation(x => x.CreatedBy)
                       .AutoInclude();

            modelBuilder.Entity<ItemDbo>()
                        .HasOne(x => x.AssignedTo)
                        .WithMany()
                        .HasForeignKey(x => x.AssignedToId);
            modelBuilder.Entity<ItemDbo>()
                       .Navigation(x => x.AssignedTo)
                       .AutoInclude();

            modelBuilder.Entity<ItemDbo>()
                        .HasOne(x => x.Board)
                        .WithMany(x => x.Items)
                        .HasForeignKey(x => x.BoardId);
            //modelBuilder.Entity<ItemDbo>()
            //           .Navigation(x => x.Board)
            //           .AutoInclude();

            modelBuilder.Entity<ItemDbo>()
                        .HasOne(x => x.ParentItem)
                        .WithOne()
                        .HasForeignKey<ItemDbo>(x => x.ParentItemId);
            //modelBuilder.Entity<ItemDbo>()
            //           .Navigation(x => x.ParentItem)
            //           .AutoInclude();

            modelBuilder.Entity<ItemDbo>()
                        .HasMany(x => x.SubItems)
                        .WithOne();
            //modelBuilder.Entity<ItemDbo>()
            //           .Navigation(x => x.SubItems)
            //           .AutoInclude();


            modelBuilder.Entity<BoardDbo>()
                        .HasOne(x => x.Owner)
                        .WithMany()
                        .HasForeignKey(x => x.OwnerId);
            modelBuilder.Entity<BoardDbo>()
                       .Navigation(x => x.Owner)
                       .AutoInclude();

            //TODO: add m:m 
            modelBuilder.Entity<BoardDbo>()
                        .HasMany(x => x.SharedUsers);
            modelBuilder.Entity<BoardDbo>()
                       .Navigation(x => x.SharedUsers)
                       .AutoInclude();

            //modelBuilder.Entity<BoardDbo>()
            //            .HasMany(x => x.Items)
            //            .WithOne(x => x.Board);
            //modelBuilder.Entity<BoardDbo>()
            //           .Navigation(x => x.Items)
            //           .AutoInclude();
        }
    }
}
