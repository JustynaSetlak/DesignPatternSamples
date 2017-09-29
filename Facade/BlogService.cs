using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class BlogService
    {
        private readonly string _baseUrl = "https://jsonplaceholder.typicode.com";

        public async Task<Post> GetPost(int id)
        {
            Post post = null;
            using (var client = new HttpClient())
            {               
                var response = await client.GetAsync($"{_baseUrl}/posts/{id}");
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                post = JsonConvert.DeserializeObject<Post>(stringResponse);
                return post;
            }
        }

        public async Task<int> GetNumberOfPosts()
        {
            List<Post> posts = null;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{_baseUrl}/posts");
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                posts = JsonConvert.DeserializeObject<List<Post>>(stringResponse);
                return posts.Count;
            }
        }
    }
}
