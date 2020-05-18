using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Model;

namespace Client
{
    class Program
    { 
        private static readonly HttpClient client = new HttpClient();
        
        static async Task Main(string[] args)
        {
            var repositories = await getDataAsync();

            foreach (var rep in repositories)
            {
                Console.WriteLine(rep.id);
                Console.WriteLine(rep.Name);
                Console.WriteLine(rep.color);
                Console.WriteLine(rep.orderNumber);
                Console.WriteLine(rep.Birthdate);
                Console.WriteLine(rep.favoriteDish);
            }

            sellaCat(4, 1);
            sellaCat(5, 1);
            
            
            Console.WriteLine("SOLD CATS");
            
            
            var repositories2 = await getNotSoldCats();

            foreach (var rep in repositories2)
            {
                Console.WriteLine(rep.id);
                Console.WriteLine(rep.Name);
                Console.WriteLine(rep.color);
                Console.WriteLine(rep.orderNumber);
                Console.WriteLine(rep.Birthdate);
                Console.WriteLine(rep.favoriteDish);
            }

        }

        private static async Task<List<Cat>> getDataAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("getting data...");
            var streamTask = client.GetStreamAsync("http://localhost:5000/cats/getall");
            var repository = await JsonSerializer.DeserializeAsync<List<Cat>>(await streamTask);

            return repository;

        }
        
        private static async Task<Cat> sellaCat(int catId, int orderId)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("getting data...");
            var streamTask = client.GetStreamAsync($"http://localhost:5000/cats/ordercat/{catId},{orderId}");
            var repository = await JsonSerializer.DeserializeAsync<Cat>(await streamTask);
            
            return repository; 
            
        }
        
        private static async Task<List<Cat>> getNotSoldCats()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("getting data...");
            var streamTask = client.GetStreamAsync("http://localhost:5000/cats/getsold");
            var repository = await JsonSerializer.DeserializeAsync<List<Cat>>(await streamTask);

            return repository;

        }
       
       
    }
}