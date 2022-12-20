using Asm2.Data;
using Asm2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asm2.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CategoryController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categorys.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cate = await _context.Categorys
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (cate == null)
            {
                return NotFound();
            }

            return View(cate);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category model)
        {
            if (ModelState.IsValid)
            {
                Category cate = new Category
                {
                    CategoryName = model.CategoryName,
                    CategoryDescription = model.CategoryDescription,
                };
                _context.Add(cate);
                await _context.SaveChangesAsync();
            }
            return View();
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cate = await _context.Categorys.FindAsync(id);
            if (cate == null)
            {
                return NotFound();
            }
            return View(cate);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Category cate = new Category
                    {
                        CategoryName = model.CategoryName,
                        CategoryDescription = model.CategoryDescription,
                    };
                    _context.Add(cate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CateExists(model.CategoryId))
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
            return View();
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cate = await _context.Categorys
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (cate == null)
            {
                return NotFound();
            }

            return View(cate);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cate = await _context.Categorys.FindAsync(id);
            _context.Categorys.Remove(cate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CateExists(int id)
        {
            return _context.Categorys.Any(e => e.CategoryId == id);
        }

    }
}
