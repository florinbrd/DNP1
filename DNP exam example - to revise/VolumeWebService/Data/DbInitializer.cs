using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace VolumeWebService.VolumeCalculator
{
    public class DbInitializer
    {
        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VolumeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VolumeContext>>()))
            {
                // Look for any movies.
                if (context.results.Any())
                {
                    return;   // DB has been seeded
                }

                context.results.AddRange(
                    new VolumeResult
                    {
                        type = "Cylinder",
                        Height = 3,
                        Radius = 3,
                        Volume = 33
                    },

                    new VolumeResult
                    {
                        type = "Cylinder",
                        Height = 4,
                        Radius = 4,
                        Volume = 44
                    },

                    new VolumeResult
                    {
                        type = "Cylinder",
                        Height = 5,
                        Radius = 5,
                        Volume = 55
                    }
                );
                context.SaveChanges();
            }
        }
    }
}