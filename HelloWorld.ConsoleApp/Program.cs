using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings.Get("ApiBaseAddress"));
            client.DefaultRequestHeaders.Accept.Clear();
            MyAPIGetGreeting(client).Wait();
        }

        static async Task MyAPIGetGreeting(HttpClient client)
        {
            using (client)
            {
                HttpResponseMessage res = await client.GetAsync("api/HelloWorld");
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    string greeting = await res.Content.ReadAsStringAsync();
                    Console.WriteLine("---------------------Calling Get Greeting Operation------------------------");
                    Console.WriteLine("{0}", greeting);
                    Console.ReadLine();
                }
            }
        }
    }
}
