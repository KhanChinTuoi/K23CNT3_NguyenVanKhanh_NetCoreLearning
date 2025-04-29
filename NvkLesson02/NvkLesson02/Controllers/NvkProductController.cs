using Microsoft.AspNetCore.Mvc;

namespace NvkLesson02.Controllers
{
    public class NvkProductController : Controller
    {
        public IActionResult NvkIndex()
        {
            ViewData["messageData"] = "Du lieu tu viewData";
            ViewBag.messageData = "Du lieu tu ViewBag";
            TempData["messageData"] = "Du lieu TempData";
            return View();
        }
    }
}
