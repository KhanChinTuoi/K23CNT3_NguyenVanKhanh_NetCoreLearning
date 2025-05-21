using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NvkLesson05.Models;
using NvkLesson05.Models.DataModels;

namespace NvkLesson05.Controllers
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
            NvkMember nvkMember = new NvkMember();
            nvkMember.NvkMemberId = Guid.NewGuid().ToString();
            nvkMember.NvkUserName = "Nguyen Khanh";
            nvkMember.NvkPassword = "123456@";
            nvkMember.NvkFullname = "Nguyen Van Khanh";
            nvkMember.NvkEmail = "khanhvank9t727@gmail.com";
            return View(nvkMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
