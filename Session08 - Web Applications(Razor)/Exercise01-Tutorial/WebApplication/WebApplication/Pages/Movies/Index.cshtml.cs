using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using WebApplication;
using WebApplication.DataModel;

namespace WebApplication
{
    public class IndexModel : PageModel
    {
        private readonly MoviesContext context;

        public IndexModel(MoviesContext context)
        {
            this.context = context;
        }

        public IList<Movie> Movie { get;set; }
        
        [BindProperty(SupportsGet = true)] public string SearchString { get; set; } //http://localhost:1337/Movies?searchstring=Ranger

        public SelectList Genres { get; set; }
        
        public SelectList Ratings { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }
        
        public string MovieRating { get; set; }
        
        
        
        
        
        
        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in context.Movies
                orderby m.Genre
                select m.Genre;

            IQueryable<string> ratingQuery = from m in context.Movies
                orderby m.Rating
                select m.Rating;

            var movies = from m in context.Movies
                select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            
            if (!string.IsNullOrEmpty(MovieRating))
            {
                movies = movies.Where(x => x.Rating == MovieRating);
            }
            
            
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Ratings = new SelectList(await ratingQuery.Distinct().ToListAsync());
            
            Movie = await movies.ToListAsync();
        }
        
        
    }
}
