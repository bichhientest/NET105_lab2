using Microsoft.EntityFrameworkCore;
namespace NET105_lab2._1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<employee> employees { get; set; }
        public DbSet<department> departments { get; set; }
        public DbSet<customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<customer>().HasIndex(c => c.Email).IsUnique();
        }
    }
}
