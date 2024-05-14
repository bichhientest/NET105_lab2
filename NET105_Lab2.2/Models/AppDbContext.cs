using Microsoft.EntityFrameworkCore;
using NET105_Lab2._2.Models;
namespace NET105_lab2._2.Models
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

