using Microsoft.EntityFrameworkCore;

namespace Old_stuff_exchange.Entity
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        #region
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Role>  Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Comment>().HasOne(c => c.User)
                .WithMany().HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Post>().HasOne(p => p.User)
                .WithMany().HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
