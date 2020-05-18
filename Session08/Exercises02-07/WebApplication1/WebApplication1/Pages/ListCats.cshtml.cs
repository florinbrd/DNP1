using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebApplication1.Pages
{
    public class ListCats : PageModel
    {
        private static HttpClient client = new HttpClient();
        
        public IList<Cats> cats { get; set; }
        

        public async Task OnGet()
        {
            cats = new List<Cats>();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
           var streamTask = client.GetStreamAsync("http://localhost:5000/cats/getall");
           var options = new JsonSerializerOptions();
          cats = await JsonSerializer.DeserializeAsync<List<Cats>>(await streamTask, options);

           foreach (var c in cats)
           {
               Console.WriteLine(c.id);
               Console.WriteLine(c.color);
           }

        }

      
    }
}