using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Postagens.Models;

namespace Postagens.Services
{
    public class PostsServices
    {
        string base_url = "https://jsonplaceholder.typicode.com";
        PostModel postagem;
        JsonSerializerOptions serializerOptions;

        PostsServices()
        {
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }


        public async Task<PostModel> getPost()
        {



            Uri uri = new Uri($"{base_url}/post");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            postagem = JsonSerializer.Deserialize<PostModel>( content, serializerOptions);
            return postagem;

        }


    }
}
