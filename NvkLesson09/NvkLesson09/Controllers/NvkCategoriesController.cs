using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NvkLesson09.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NvkLesson09.Controllers
{
    public class NvkCategoriesController : Controller
    {
        private readonly NvkBookStoreContext _context;

        public NvkCategoriesController(NvkBookStoreContext context)
        {
            _context = context;
        }

        // GET: NvkCategories
        public async Task<IActionResult> NvkIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: NvkCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: NvkCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NvkCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NvkIndex));
            }
            return View(category);
        }

        // GET: NvkCategories/Edit/5
        public async Task<IActionResult> Edit(int? Nvkid)
        {
            if (Nvkid == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(Nvkid);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: NvkCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Nvkid, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (Nvkid != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(NvkIndex));
            }
            return View(category);
        }

        // GET: NvkCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: NvkCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NvkIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
