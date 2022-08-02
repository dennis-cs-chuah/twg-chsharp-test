using Microsoft.AspNetCore.Mvc;

namespace CSharpTest
{
    public class ProductController : Controller
    {
        public IActionResult Index ()
        {
            return View ();
        }
    }
}
