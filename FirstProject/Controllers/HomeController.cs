using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("[GET][Home/Index]-[User: {User}]", User.Identity?.Name ?? "Unknow");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("[GET][Home/Privacy]-[User: {User}]", User.Identity?.Name ?? "Unknow");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogError("[Home]-[User: {User}]", User.Identity?.Name ?? "Unknow");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
