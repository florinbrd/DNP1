using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Entities;

namespace WebApplication1.Pages
{
    public class buycat : PageModel
    {


        [BindProperty(SupportsGet = true)] public int catId { get; set; }
        [BindProperty(SupportsGet = true)] public int orderId { get; set; }

        public async Task OnPost()
        {

            sellaCat(catId, orderId);

        }
        
        private static async Task sellaCat(int catId, int orderId)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("getting data...");
            var streamTask = client.GetStreamAsync($"http://localhost:5000/cats/ordercat/{catId},{orderId}");
           
            
        }




    }
}

        
        
  
    
