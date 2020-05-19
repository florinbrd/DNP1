using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using VolumeWeb.Data;
using VolumeWeb.Models;
using VolumeWebService.VolumeCalculator;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace VolumeWeb.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly VolumeContext _context;

        public IndexModel(VolumeContext context)
        {
            _context = context;
        }

        public IList<VolumeResult> results { get;set; }
         

        public async Task OnGetAsync()
        {
            HttpClient client = new HttpClient();
            results = new List<VolumeResult>();


            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            var streamTask =   client.GetStreamAsync("https://localhost:5001/calculate");
            
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
           
             results = await JsonSerializer.DeserializeAsync<List<VolumeResult>>(await streamTask,options);
             foreach (var e in results)
             {
                 Console.WriteLine(e.type);
                 Console.WriteLine(e.Height);
                 Console.WriteLine(e.Radius);
                 Console.WriteLine(e.Volume);
             }

            
        }
    }
}
