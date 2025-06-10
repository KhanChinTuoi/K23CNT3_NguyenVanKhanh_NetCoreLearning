using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NvkLesson08.Models;

namespace NvkLesson08.Controllers
{
    public class NvkAccountController : Controller
    {
        private static List<NvkAccount> nvkAccounts = new List<NvkAccount>()
        {
            new NvkAccount
                {
                    NvkId = 231090047,
                    NvkFullName = "Nguyen Van Khanh",
                    NvkEmail = "khanhvank9t727@gmail.com",
                    NvkPhone = "0984915173",
                    NvkAddress = "Lớp K23CNT3",
                    NvkAvatar = "k9t.jpg",
                    NvkBirthday = new DateTime(2005, 5, 29),
                    NvkGender = "Nam",
                    NvkPassword = "k9t72769",
                    NvkFacebook = "https://facebook.com/dsdauvn"
                },
                new NvkAccount
                {
                    NvkId = 2,
                    NvkFullName = "Trần Thị B",
                    NvkEmail = "tranthib@example.com",
                    NvkPhone = "0987654321",
                    NvkAddress = "456 Đường B, Quận 3, TP.HCM",
                    NvkAvatar = "avatar2.jpg",
                    NvkBirthday = new DateTime(1992, 8, 15),
                    NvkGender = "Nữ",
                    NvkPassword = "password2",
                    NvkFacebook = "https://facebook.com/tranthib"
                },
                new NvkAccount
                {
                    NvkId = 3,
                    NvkFullName = "Lê Văn C",
                    NvkEmail = "levanc@example.com",
                    NvkPhone = "0911222333",
                    NvkAddress = "789 Đường C, Quận 5, TP.HCM",
                    NvkAvatar = "avatar3.jpg",
                    NvkBirthday = new DateTime(1988, 12, 1),
                    NvkGender = "Nam",
                    NvkPassword = "password3",
                    NvkFacebook = "https://facebook.com/levanc"
                },
                new NvkAccount
                {
                    NvkId = 4,
                    NvkFullName = "Phạm Thị D",
                    NvkEmail = "phamthid@example.com",
                    NvkPhone = "0909876543",
                    NvkAddress = "321 Đường D, Quận 7, TP.HCM",
                    NvkAvatar = "avatar4.jpg",
                    NvkBirthday = new DateTime(1995, 3, 10),
                    NvkGender = "Nữ",
                    NvkPassword = "password4",
                    NvkFacebook = "https://facebook.com/phamthid"
                },
                new NvkAccount
                {
                    NvkId = 5,
                    NvkFullName = "Hoàng Văn E",
                    NvkEmail = "hoangvane@example.com",
                    NvkPhone = "0933444555",
                    NvkAddress = "654 Đường E, Quận 10, TP.HCM",
                    NvkAvatar = "avatar5.jpg",
                    NvkBirthday = new DateTime(1991, 7, 22),
                    NvkGender = "Nam",
                    NvkPassword = "password5",
                    NvkFacebook = "https://facebook.com/hoangvane"
                }
        };
        // GET: NvkAccountController
        public ActionResult NvkIndex()
        {
            return View(nvkAccounts);
        }

        // GET: NvkAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NvkAccountController/NvkCreate
        public ActionResult NvkCreate()
        {
            var nvkModel = new NvkAccount();
            return View(nvkModel);
        }

        // POST: NvkAccountController/NvkCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvkCreate(NvkAccount nvkModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    nvkAccounts.Add(nvkModel);
                    return RedirectToAction(nameof(Index));
                }

                // Nếu dữ liệu không hợp lệ, trả về View để người dùng sửa
                return View(nvkModel);
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây nếu cần
                ModelState.AddModelError("", "Có lỗi xảy ra khi thêm mới: " + ex.Message);
                return View(nvkModel);
            }
        }

        // GET: NvkAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NvkAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvkAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NvkAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
