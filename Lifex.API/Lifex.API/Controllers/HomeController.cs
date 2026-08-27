using Microsoft.AspNetCore.Mvc;
using LifEx.Infrastructure.Services;

namespace LifEx.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILifExRepository _repository;

        public HomeController(ILifExRepository repository)
        {
            _repository = repository;
        }

        // GET: /Home/Welcome
        public async Task<IActionResult> Welcome()
        {
            var paths = await _repository.GetPathsAsync();

            return View(paths);
        }
    }
}