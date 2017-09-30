using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiService apiService = new ApiService(new HttpClient());
            var response = apiService.Get("https://jsonplaceholder.typicode.com/posts/1").GetAwaiter().GetResult();
            Console.WriteLine(response);

            Console.ReadKey();
        }
    }
}
