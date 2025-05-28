using Microsoft.AspNetCore.Mvc;
using NvkLab06.Models;

namespace NvkLab06.Controllers
{
    public class NvkEmployeeController : Controller
    {
        private static List<NvkEmployee> nvkEmployees = new List<NvkEmployee>()
        {
            new NvkEmployee
            {
                NvkId = 1,
                NvkName = "Nguyễn Văn Khánh",
                NvkBirthday = new DateTime(2005 , 5, 29),
                NvkEmail = "khanhvank9t727@gmail.com.com",
                NvkPhone = "0983915173",
                NvkSalary = 15000000,
                NvkStatus = true
            },
            new NvkEmployee
            {
                NvkId = 2,
                NvkName = "Trần Thị B",
                NvkBirthday = new DateTime(2004 , 4 , 16 ),
                NvkEmail = "tranthib@example.com",
                NvkPhone = "0912345678",
                NvkSalary = 18000000,
                NvkStatus = true
            },
            new NvkEmployee
            {
                NvkId = 3,
                NvkName = "Lê Văn C",
                NvkBirthday = new DateTime(2005 , 12, 10),
                NvkEmail = "levanc@example.com",
                NvkPhone = "0934567890",
                NvkSalary = 12000000,
                NvkStatus = false
            },
            new NvkEmployee
            {
                NvkId = 4,
                NvkName = "Phạm Thị D",
                NvkBirthday = new DateTime(2003 , 3, 22),
                NvkEmail = "phamthid@example.com",
                NvkPhone = "0978123456",
                NvkSalary = 20000000,
                NvkStatus = true
            },
            new NvkEmployee
            {
                NvkId = 5,
                NvkName = "Hoàng Văn E",
                NvkBirthday = new DateTime(2004 , 7, 30),
                NvkEmail = "hoangvane@example.com",
                NvkPhone = "0987654321",
                NvkSalary = 22000000,
                NvkStatus = false
            }
        };

        public ActionResult NvkIndex()
        {
            return View(nvkEmployees);
        }

        // GET: NvkEmployee/NvkCreate
        public ActionResult NvkCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NvkCreate(NvkEmployee model)
        {
            if (ModelState.IsValid)
            {
                // tu dong tang ID
                int newId = nvkEmployees.Any() ? nvkEmployees.Max(e => e.NvkId) + 1 : 1;
                model.NvkId = newId;

                nvkEmployees.Add(model);

                //chuyen huong ve trang danh sach
                return RedirectToAction("NvkIndex");    
            }

            // Nếu có lỗi, trả lại view form để sửa
            return View(model);
        }

        [HttpGet]
        public IActionResult NvkEdit(int id)
        {
            var NvkEmp = nvkEmployees.FirstOrDefault(e => e.NvkId == id);
            return View(NvkEmp);
        }

        [HttpPost]
        public IActionResult NvkEditPUT(NvkEmployee updatedEmp)
        {
            var NvkEmp = nvkEmployees.FirstOrDefault(e => e.NvkId == updatedEmp.NvkId);
            if (NvkEmp != null)
            {
                NvkEmp.NvkName = updatedEmp.NvkName;
                NvkEmp.NvkBirthday = updatedEmp.NvkBirthday;
                NvkEmp.NvkEmail = updatedEmp.NvkEmail;
                NvkEmp.NvkPhone = updatedEmp.NvkPhone;
                NvkEmp.NvkSalary = updatedEmp.NvkSalary;
                NvkEmp.NvkStatus = updatedEmp.NvkStatus;
            }
            return RedirectToAction("NvkIndex");
        }

        public IActionResult NvkDelete(int id)
        {
            var NvkEmp = nvkEmployees.FirstOrDefault(e => e.NvkId == id);
            if (NvkEmp != null) nvkEmployees.Remove(NvkEmp);
            return RedirectToAction("NvkIndex");
        }
    }
}
    