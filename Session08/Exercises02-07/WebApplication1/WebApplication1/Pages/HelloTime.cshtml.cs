using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class HelloTime : PageModel
    {
        public void OnGet()
        {
            ViewData["MyTitle"] = "Hello"; 
            ViewData["MyObject"] = new Post
            {
                Number = 1, Title = "This is a post from life", 
                Text = "This is a post that I am trying it out to see how it works out", LengthMessage = 100
            };
            ViewData["MyNumber"] = 12;
            
        }
    }
}