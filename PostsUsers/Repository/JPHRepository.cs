using Newtonsoft.Json;
using PostsUsers.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PostsUsers.Repository
{
    public class JPHRepository : IRepository
    {
        static readonly HttpClient client = new HttpClient();


        public async Task<List<User>> GetAllUsers()
        {
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<User>>(json);
        }

        public async Task<List<Post>> GetPosts(int userId)
        {
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts?userId=" + userId);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Post>>(json);
        }
    }
}
