using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;
using WebApplication.DataModel;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MoviesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return; // DB has been seeded
                }


                var movies = new Movie[]
                {
                    new Movie
                    {
                        Id = 1, Title = "Rangers", Genre = "Action", Price = 2.2M,
                        ReleaseDate = new DateTime(2000, 10, 10),
                        Rating = "A good movie"
                    },
                    new Movie
                    {
                        Id = 2, Title = "Foo Fighters", Genre = "Thriller", Price = 1.2M,
                        ReleaseDate = new DateTime(2001, 10, 10),
                        Rating = "A decent movie"
                    },
                    new Movie
                    {
                        Id = 3, Title = "WuTang", Genre = "Shaolin", Price = 2.2M,
                        ReleaseDate = new DateTime(2010, 10, 10),
                        Rating = "A very very good movie movie"
                    },
                    new Movie
                    {
                        Id = 4, Title = "Intergalatic", Genre = "Sci-Fi", Price = 1.2M,
                        ReleaseDate = new DateTime(2005, 10, 10),
                        Rating = "A good movie"
                    },
                    new Movie
                    {
                        Id = 5, Title = "Superman vs Batman", Genre = "Sci Fi", Price = 5.2M,
                        ReleaseDate = new DateTime(2003, 10, 10),
                        Rating = "A good movie"
                    }
                };

                foreach (var c in movies)
                {
                    context.Movies.Add(c);
                }

                context.SaveChangesAsync();



            }
        }
    }
}
