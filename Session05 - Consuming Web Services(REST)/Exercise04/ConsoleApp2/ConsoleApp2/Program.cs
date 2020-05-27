using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        
        static async Task Main(string[] args)
        {
            var repositories = await getDataAsync();

            foreach (var rep in repositories)
            {
                Console.WriteLine(rep.name);
            }
            
        }

        private static async Task<List<User>> getDataAsync()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            Console.WriteLine("getting data...");
            var streamTask = client.GetStreamAsync("https://jsonplaceholder.typicode.com/users");
            var repository = await JsonSerializer.DeserializeAsync<List<User>>(await streamTask);

            return repository;

        }
    }
}