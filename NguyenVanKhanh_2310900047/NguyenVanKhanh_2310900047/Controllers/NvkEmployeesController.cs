using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenVanKhanh_2310900047.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenVanKhanh_2310900047.Controllers
{
    public class NvkEmployeesController : Controller
    {
        private readonly NguyenVanKhanh2310900047Context _context;

        public NvkEmployeesController(NguyenVanKhanh2310900047Context context)
        {
            _context = context;
        }

        // GET: NvkEmployees
        public async Task<IActionResult> NvkIndex()
        {
            return View(await _context.NvkEmployees.ToListAsync());
        }

        // GET: NvkEmployees/Details/5
        public async Task<IActionResult> NvkDetails(int? NvkId)
        {
            if (NvkId == null) return NotFound();
            var emp = await _context.NvkEmployees.FirstOrDefaultAsync(m => m.NvkEmpId == NvkId);
            return emp == null ? NotFound() : View(emp);
        }

        // GET: NvkEmployees/NvkCreate
        [HttpGet]
        public IActionResult NvkCreate()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvkCreate(NvkEmployee emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NvkIndex));
            }
            return View(emp);
        }

        // GET: NvkEmployees/NvkEdit/5
        public async Task<IActionResult> NvkEdit(int? Nvkid)
        {
            if (Nvkid == null)
            {
                return NotFound();
            }

            var nvkEmployee = await _context.NvkEmployees.FindAsync(Nvkid);
            if (nvkEmployee == null)
            {
                return NotFound();
            }
            return View(nvkEmployee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvkEdit(int NvkId, NvkEmployee emp)
        {
            if (NvkId != emp.NvkEmpId) return NotFound();
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.NvkEmployees.Any(e => e.NvkEmpId == emp.NvkEmpId))
                        return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(NvkIndex));
            }
            return View(emp);
        }


        public async Task<IActionResult> NvkDelete(int? NvkId)
        {
            if (NvkId == null) return NotFound();
            var emp = await _context.NvkEmployees.FirstOrDefaultAsync(m => m.NvkEmpId == NvkId);
            return emp == null ? NotFound() : View(emp);
        }

        [HttpPost, ActionName("NvkDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvkDeleteConfirmed(int NvkId)
        {
            var emp = await _context.NvkEmployees.FindAsync(NvkId);
            if (emp != null)
            {
                _context.NvkEmployees.Remove(emp);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(NvkIndex));
        }
    }
}
