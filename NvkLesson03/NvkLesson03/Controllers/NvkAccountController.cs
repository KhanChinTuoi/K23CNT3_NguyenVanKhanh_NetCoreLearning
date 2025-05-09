using Microsoft.AspNetCore.Mvc;
using NvkLesson03.Models;

namespace NvkLesson03.Controllers
{
    public class NvkAccountController : Controller
    {
        public IActionResult NvkIndex()
        {
            List<NvkAccount> accounts = new List<NvkAccount>
            {
                new NvkAccount()
                {
                    NvkId = 1, NvkName = "Nguyen Van Khanh",
                    NvkEmail="khanhvank9t727@gmail.com",
                    NvkPhone="0984915173",
                    NvkAddress="Ha Noi",
                    NvkAvatar= Url.Content("~/Avatar/download.jpg"),
                    NvkGender=1, NvkBio="idk",
                    NvkBirthday= new DateTime(2005,5,29)
                },
                new NvkAccount()
                {
                    NvkId = 2, NvkName = "Nguyen Van Khan",
                    NvkEmail="khanhvank9t@gmail.com",
                    NvkPhone="0984915172",
                    NvkAddress="Ha Noi",
                    NvkAvatar= Url.Content("~/Avatar/emu.jpg"),
                    NvkGender=1, NvkBio="idk",
                    NvkBirthday= new DateTime(2005,4,28)
                },
                new NvkAccount()
                {
                    NvkId = 3, NvkName = "Nguyen Van Kha",
                    NvkEmail="khanhvank9t7@gmail.com",
                    NvkPhone="0984915171",
                    NvkAddress="Ha Noi",
                    NvkAvatar= Url.Content("~/Avatar/luka.jpg"),
                    NvkGender=1, NvkBio="idk",
                    NvkBirthday= new DateTime(2005,3,27)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }

        public IActionResult NvkProfile()
        {
            NvkAccount account = new NvkAccount()
            {
                NvkId = 1,
                NvkName = "Nguyen Van Khanh",
                NvkEmail = "khanhvank9t727@gmail.com",
                NvkPhone = "0984915173",
                NvkAddress = "Ha Noi",
                NvkAvatar = "/images/Avatar/download.jpg",
                NvkGender = 1,
                NvkBio = "idk",
                NvkBirthday = new DateTime(2005,5,29)
            };
            ViewBag.Accounts = account;
            return View(); 
        }
    }
}
