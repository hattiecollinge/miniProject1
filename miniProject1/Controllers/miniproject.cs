using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;
using System.Net.Http;
using RestSharp;
using miniProject1.services;
using System.Reflection.Metadata.Ecma335;

namespace miniProject1.Controllers
{
    public class joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
        public string type { get; set; }
    }
    public class jokeController : Controller
    {
        [HttpGet("joke")]
        public joke jokeSetup()
        {
            var jokeSet = ApiService.GetData<joke>("https://official-joke-api.appspot.com/random_joke");
            return jokeSet;

        }
    }
}
