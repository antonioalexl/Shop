using Microsoft.AspNetCore.Mvc;

namespace Shop.Web.Mvc
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
