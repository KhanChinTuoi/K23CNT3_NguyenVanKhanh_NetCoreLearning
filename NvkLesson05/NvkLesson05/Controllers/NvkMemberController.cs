using Microsoft.AspNetCore.Mvc;
using NvkLesson05.Models.DataModels;

namespace NvkLesson05.Controllers
{
    public class NvkMemberController : Controller
    {
        public static List<NvkMember> nvkListMember = new List<NvkMember>()
        {
             new NvkMember
            {
                NvkMemberId = "MB001",
                NvkUserName = "khan9tuoi",
                NvkPassword = "123456asd",
                NvkFullname = "Nguyen Van Khanh",
                NvkEmail = "khanhvank9t727@gmail.com"
            },
            new NvkMember
            {
                NvkMemberId = "MB002",
                NvkUserName = "bob456",
                NvkPassword = "bobPass@123",
                NvkFullname = "Bob Smith",
                NvkEmail = "bob@example.com"
            },
            new NvkMember
            {
                NvkMemberId = "MB003",
                NvkUserName = "charlie789",
                NvkPassword = "charlie@789",
                NvkFullname = "Charlie Brown",
                NvkEmail = "charlie@example.com"
            },
            new NvkMember
            {
                NvkMemberId = "MB004",
                NvkUserName = "daisy321",
                NvkPassword = "daisy#321",
                NvkFullname = "Daisy Miller",
                NvkEmail = "daisy@example.com"
            },
            new NvkMember
            {
                NvkMemberId = "MB005",
                NvkUserName = "edward654",
                NvkPassword = "edward654!",
                NvkFullname = "Edward Wilson",
                NvkEmail = "edward@example.com"
            }
        };
        public IActionResult NvkIndex() //List Member
        {

            return View(nvkListMember);
        }
    }
}
