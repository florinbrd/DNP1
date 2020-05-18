using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        private static readonly HttpClient client = new HttpClient();
        
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                
                new MediaTypeWithQualityHeaderValue("application/json"));

            var stringTask = client.GetStringAsync("https://jsonplaceholder.typicode.com/todos?userId=10");

            var msg = await stringTask;
            Console.WriteLine(msg);
        }
    }
}