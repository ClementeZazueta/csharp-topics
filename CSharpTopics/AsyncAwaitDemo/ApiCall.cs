using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    public class ApiCall
    {
        private readonly HttpClient _client;

        public ApiCall()
        {
            _client = new HttpClient();
        }

        public async Task CallingStartwarsApi()
        {
            var defaulColor = Console.ForegroundColor;
            var response = await _client.GetAsync("https://swapi.dev/api/people/1");
            var responseContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(responseContent);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Api fetched");
            Console.ForegroundColor = defaulColor;
        }
    }
}
