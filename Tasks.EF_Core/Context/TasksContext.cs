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
            //modelBuilder.Entity<UserDbo>().ToTable("Users");
            //modelBuilder.Entity<TokenDbo>().ToTable("Tokens");

            //modelBuilder.Entity<TokenDbo>()
            //            .HasOne(x => x.UserData)
            //            .WithOne()
            //            .HasForeignKey<TokenDbo>(x => x.UserId);
        }
    }
}
