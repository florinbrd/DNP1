using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Newtonsoft.Json;
using VolumeWeb.Data;
using VolumeWeb.Models;
using VolumeWebService.VolumeCalculator;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace VolumeWeb.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly VolumeContext _context;

        public CreateModel(VolumeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty] public VolumeResult result { get; set; }
        [BindProperty] public string Type { get; set; }



        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            HttpClient client = new HttpClient();
            var options = new JsonSerializerOptions() {PropertyNameCaseInsensitive = true};
            Console.WriteLine(Type);
            var json = client.GetStreamAsync($"https://localhost:5001/calculate/{Type}?height={result.Height}&radius={result.Radius}");


        VolumeResult results = await JsonSerializer.DeserializeAsync<VolumeResult>(await json, options);

        result = results;


//            return RedirectToPage("./Index");

        return Page();
    }
}

}