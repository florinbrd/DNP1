using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        
        static async Task Main(string[] args)
        {
            var word = await getWord();

           Console.WriteLine(word);
           
           string word2 = word.Trim(new char[]{'"','[',']'});
           Console.WriteLine(word2);
           
           guessWord(word2);
           
        }

        static async Task<string> getWord()
        {
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                Console.WriteLine("getting data...");
                
                var streamTask = client.GetStringAsync("https://random-word-api.herokuapp.com/word?number=1");
                var repository = await streamTask;

                return repository;

            }
        }

        static void guessWord(string word)
        {
            int count = 0; 
            
            Console.WriteLine("Guess the word:");
            string answer = Console.ReadLine();

            while (!answer.Equals(word))
            {
                Console.WriteLine("Wrong answer, try again: ");
                answer = Console.ReadLine();
                count++; 
            }
            
            Console.WriteLine($"You guessed it, it took you {count} times to get it.");
        }
    }
}