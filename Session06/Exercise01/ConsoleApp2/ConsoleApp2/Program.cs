using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> data = GetDataAsync();

            string result = data.GetAwaiter().GetResult();
            
            Console.WriteLine(result);
        }

        static async Task<string> GetDataAsync()
        {
            HttpClient client = new HttpClient();
            Console.WriteLine("get that data for you...");

            string s = await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos?userId=1");
            return s; 
        }
    }
}