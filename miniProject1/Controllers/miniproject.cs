using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;
using System.Net.Http;
using RestSharp;

namespace miniProject1.Controllers
{
    public class joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
        public string type { get; set; }
    }
    public class jokeController    : Controller
    {
        [HttpGet("joke")]
        public joke randomjoke()
        {
            RestSharp.RestClient client = new();
            string URL = "https://official-joke-api.appspot.com/random_joke";
             RestRequest restRequest = new RestRequest(URL);
            var joke = client.Get<joke>(restRequest);
            return joke;
        }
    }
}
