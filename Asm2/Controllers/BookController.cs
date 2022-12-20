using Asm2.Data;
using Asm2.Models;
using Asm2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asm2.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public BookController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this.webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Books.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniFileName = UploadFile(model);
                Book book = new Book
                {
                    Title = model.Title,
                    Description = model.Description,
                    Quantity = model.Quantity,
                    Year = model.Year,
                    Price = model.Price,
                    ImageUrl = uniFileName,
                };
                _context.Add(book);
                await _context.SaveChangesAsync();
            }
            return View();
        }

        private string UploadFile(BookViewModel model)
        {
            string uniFileName = null;
            if (model.BookPicture != null)
            {
                string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniFileName = Guid.NewGuid().ToString() + "_" + model.BookPicture.FileName;
                string filePath = Path.Combine(uploadFolder, uniFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                model.BookPicture.CopyTo(fileStream);
            }
            return uniFileName;
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string uniFileName = UploadFile(model);
                    Book book = new Book
                    {
                        Title = model.Title,
                        Description = model.Description,
                        Quantity = model.Quantity,
                        Year = model.Year,
                        Price = model.Price,
                        ImageUrl = uniFileName,
                    };
                    _context.Add(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(model.B))
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

            var book = await _context.Books
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.BookId == id);
        }
    }
}
