using Microsoft.AspNetCore.Mvc;

namespace Meetup.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
