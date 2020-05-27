using Microsoft.EntityFrameworkCore;

namespace WebApplication.DataModel
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }
        
        public DbSet<Movie> Movies { get; set;  }
    }
}