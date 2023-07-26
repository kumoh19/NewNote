using Microsoft.AspNetCore.Mvc;
using Note.BLL;
using Note.MVC6.Models;
using System.Diagnostics;

namespace Note.MVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NoticeBll _noticeBll;

        public HomeController(ILogger<HomeController> logger, NoticeBll noticeBll)
        {
            _logger = logger;
            _noticeBll = noticeBll;
        }

        public IActionResult Index()
        {
            var list = _noticeBll.GetNoticeList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}