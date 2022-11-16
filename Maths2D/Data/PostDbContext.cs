using Microsoft.EntityFrameworkCore;

namespace Maths2D.Data
{
    public class PostDbContext : DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
