using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Collections.Generic;

namespace Project3.Controllers
{
    public class quote
    {
        public string content { get; set; }
    }
    public class RandQuote : Controller
    {
        [HttpGet("quote")]
        public quote GetQuote()
        {
            RestSharp.RestClient client = new();
            string URL = "https://api.quotable.io/quotes/random";
            RestRequest request = new(URL);
            var line = client.Get<IEnumerable<quote>>(request);
            return line.First();

        }
    }
}
