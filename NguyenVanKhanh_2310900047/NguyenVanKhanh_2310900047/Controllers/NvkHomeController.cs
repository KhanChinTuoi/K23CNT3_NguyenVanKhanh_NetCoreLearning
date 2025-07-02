using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NguyenVanKhanh_2310900047.Models;

namespace NguyenVanKhanh_2310900047.Controllers
{
    public class NvkHomeController : Controller
    {
        private readonly ILogger<NvkHomeController> _logger;

        public NvkHomeController(ILogger<NvkHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NvkIndex()
        {
            return View();
        }

        public IActionResult NvkAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult NvkError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
