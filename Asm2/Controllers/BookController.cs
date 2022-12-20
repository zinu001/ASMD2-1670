using Asm2.Data;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
            return View();
        }
    }
}
