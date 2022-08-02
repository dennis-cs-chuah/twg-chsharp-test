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
            return new OkObjectResult (searchResult);
        }

        [Route("/Price"), HttpGet]
        public IActionResult Price([FromQuery] string q)
        {
            HttpClient priceClient = new ();
            string url = "https://twg.azure-api.net/bolt/price.json?UserId=21E3BC8B-CA74-4C9A-9A0F-F0748A550B92&MachineID=test&Barcode=" + q;
            HttpResponseMessage searchResponse = priceClient.GetAsync (url).Result;
            string searchResult = searchResponse.Content.ReadAsStringAsync ().Result;
            return new OkObjectResult (searchResult);
        }
    }
}
