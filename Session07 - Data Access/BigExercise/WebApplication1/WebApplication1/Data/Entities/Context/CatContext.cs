using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data.Entities.Context
{
    public class CatContext : DbContext
    {
        public CatContext()
        {
            
        }
        public CatContext(DbContextOptions<CatContext> options) : base(options)
        {
            
        }
        
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}