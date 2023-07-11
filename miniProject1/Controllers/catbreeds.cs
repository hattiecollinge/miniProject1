using Microsoft.AspNetCore.Mvc;
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
            RestSharp.RestClient client = new();
            string URL = "https://catfact.ninja/fact?max_length=140";
            RestRequest restrequest = new RestRequest(URL);
            var cat = client.Get<cats>(restrequest);
            return cat;
        }
    }
}