using api2.Controllers;
using RestSharp;

namespace miniProject1.services
{
    public class ApiService
    {
        public static Tmodel GetData<Tmodel>(string URL)
        {
            RestSharp.RestClient client = new();
            RestRequest restrequest = new RestRequest(URL);
            var data = client.Get<Tmodel>(restrequest);
            return data;
        }
    }
}
