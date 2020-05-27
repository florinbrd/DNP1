using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await getSomthingOut();
        }

        private static async Task getSomthingOut()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );

            var stringTask = client.GetStringAsync("https://localhost:5001/api/TodoItems");
            var msg = await stringTask;
            Console.WriteLine(msg);
        }
}
}