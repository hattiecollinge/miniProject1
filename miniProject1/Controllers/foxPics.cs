using api2.Controllers;
using Microsoft.AspNetCore.Mvc;
using miniProject1.services;
using RestSharp;

namespace miniProject1.Controllers
{
    public class foxes
    {
        public string image { get; set; }
    }
    public class foxPics : Controller
    {
            [HttpGet("foxes")] 
        public foxes GetFox()
        {
            var fox = ApiService.GetData<foxes>("https://randomfox.ca/floof/");
            return fox;
   
        }
    }
}
