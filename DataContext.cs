using Microsoft.EntityFrameworkCore;

namespace MovieManager
{
    public class DataContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
              Database=EFMovieDB;
              Trusted_Connection=True;
              MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
