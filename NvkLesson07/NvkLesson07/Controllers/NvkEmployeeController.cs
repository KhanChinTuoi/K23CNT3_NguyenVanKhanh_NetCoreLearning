using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NvkLesson07.Models;

namespace NvkLesson07.Controllers
{
    public class NvkEmployeeController : Controller
    {
        //Mock Data:
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
        // GET: NvkEmployeeController
        public ActionResult NvkIndex()
        {
            return View(nvkEmployees);
        }

        // GET: NvkEmployeeController/Details/5
        public ActionResult NvkDetail(int id)
        {
            var nvkEmployee = nvkEmployees.FirstOrDefault(x => x.NvkId == id);
            return View(nvkEmployee);
        }

        // GET: NvkEmployeeController/Create
        public ActionResult NvkCreate()
        {
            var nvkEmployee = new NvkEmployee();
            return View(nvkEmployee);
        }

        // POST: NvkEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvkCreate(NvkEmployee nvkModel)
        {
            try
            {
                //them moi nhan vien vao list
                nvkModel.NvkId = nvkEmployees.Max(x => x.NvkId) + 1;
                nvkEmployees.Add(nvkModel);
                return RedirectToAction(nameof(NvkIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvkEmployeeController/NvkEdit/5
        public ActionResult NvkEdit(int id)
        {
            var nvkEmployee = nvkEmployees.FirstOrDefault(x => x.NvkId == id);
            return View(nvkEmployee);
        }

        // POST: NvkEmployeeController/NvkEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvkEdit(int id, NvkEmployee nvkModel)
        {
            try
            {
                for (int i = 0; i < nvkEmployees.Count(); i++)
                {
                    if(nvkEmployees[i].NvkId == id)
                    {
                        nvkEmployees[i] = nvkModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(NvkIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NvkEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NvkEmployeeController/Delete/5
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
