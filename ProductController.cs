using Microsoft.AspNetCore.Mvc;

namespace CSharpTest
{
    public class ProductController : Controller
    {
        [Route("/Seach"), HttpGet]
        public IActionResult Search ([FromQuery] string q)
        {
            // Search
            HttpClient searchClient = new ();
            string url = "https://twg.azure-api.net/bolt/search.json?UserId=21E3BC8B-CA74-4C9A-9A0F-F0748A550B92&Search=" + q;
            HttpResponseMessage searchResponse = searchClient.GetAsync (url).Result;
            string searchResult = searchResponse.Content.ReadAsStringAsync ().Result;

            
            return new EmptyResult ();
        }
    }
}
