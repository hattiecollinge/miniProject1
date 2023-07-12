using Microsoft.AspNetCore.Mvc;
using miniProject1.services;
using RestSharp;

namespace api2.Controllers
{
    public class cats
    {
        public string fact { get; set; }


    }
    public class catbreeds : Controller
    {
        [HttpGet("cats")]
        public cats catfact()
        {
            var cat = ApiService.GetData<cats>("https://catfact.ninja/fact?max_length=140");
            return cat;
        }
    }
}