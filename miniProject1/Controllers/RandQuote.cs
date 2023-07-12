using Microsoft.AspNetCore.Mvc;
using miniProject1.services;
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
            var line = ApiService.GetData<IEnumerable<quote>>("https://api.quotable.io/quotes/random");
            return line.First();

        }
    }
}
