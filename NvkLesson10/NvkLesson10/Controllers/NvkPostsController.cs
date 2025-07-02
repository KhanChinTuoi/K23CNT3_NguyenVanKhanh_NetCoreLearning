using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NvkLesson10.Models;

namespace NvkLesson10.Controllers
{
    public class NvkPostsController : Controller
    {
        private readonly NvkK23cnt3Lesson10DbContext _context;

        public NvkPostsController(NvkK23cnt3Lesson10DbContext context)
        {
            _context = context;
        }

        // GET: NvkPosts
        public async Task<IActionResult> NvkIndex()
        {
            return View(await _context.NvkPosts.ToListAsync());
        }

        // GET: NvkPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nvkPost = await _context.NvkPosts
                .FirstOrDefaultAsync(m => m.NvkId == id);
            if (nvkPost == null)
            {
                return NotFound();
            }

            return View(nvkPost);
        }

        // GET: NvkPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NvkPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NvkId,NvkTitle,NvkImage,NvkContent,NvkStatus")] NvkPost nvkPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nvkPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nvkPost);
        }

        // GET: NvkPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nvkPost = await _context.NvkPosts.FindAsync(id);
            if (nvkPost == null)
            {
                return NotFound();
            }
            return View(nvkPost);
        }

        // POST: NvkPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NvkId,NvkTitle,NvkImage,NvkContent,NvkStatus")] NvkPost nvkPost)
        {
            if (id != nvkPost.NvkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nvkPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NvkPostExists(nvkPost.NvkId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(nvkPost);
        }

        // GET: NvkPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nvkPost = await _context.NvkPosts
                .FirstOrDefaultAsync(m => m.NvkId == id);
            if (nvkPost == null)
            {
                return NotFound();
            }

            return View(nvkPost);
        }

        // POST: NvkPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nvkPost = await _context.NvkPosts.FindAsync(id);
            if (nvkPost != null)
            {
                _context.NvkPosts.Remove(nvkPost);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NvkPostExists(int id)
        {
            return _context.NvkPosts.Any(e => e.NvkId == id);
        }
    }
}
