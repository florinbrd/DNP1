using Microsoft.EntityFrameworkCore;

namespace VolumeWebService.VolumeCalculator
{
    public class VolumeContext : DbContext
    {
        public DbSet<VolumeResult> results { get; set; }

        public VolumeContext (
            DbContextOptions<VolumeContext> options)
            : base(options)
        {
        }
    }
    
    
    

}