using Microsoft.AspNetCore.Mvc;

namespace LifEx.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Technology(int id)
        {
            return View();
        }
    }
}
