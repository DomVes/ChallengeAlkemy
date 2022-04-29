using ChallengeAlkemy.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChallengeAlkemy.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Character>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Film>().HasIndex(f => f.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
