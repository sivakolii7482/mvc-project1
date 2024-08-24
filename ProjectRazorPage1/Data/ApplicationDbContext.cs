using Microsoft.EntityFrameworkCore;
using ProjectRazorPage1.Models;

namespace ProjectRazorPage1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "siva", DisplayOrder = 1 },
                new Category { Id = 2, Name = "siyan", DisplayOrder = 2 },
                new Category { Id = 3, Name = "siddarth", DisplayOrder = 3 }
                );
        }
    }
}
