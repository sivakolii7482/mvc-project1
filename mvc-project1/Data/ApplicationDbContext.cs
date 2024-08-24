using Microsoft.EntityFrameworkCore;
using mvc_project1.Models;

namespace mvc_project1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) { 

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "siva", DisplayOrder = 1 },
                new Category { Id = 2, Name = "siyan", DisplayOrder = 1 },
                new Category { Id = 3, Name = "siddarth", DisplayOrder = 1 }
                );    }
    }
}
