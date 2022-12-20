using Microsoft.AspNetCore.Mvc;

namespace Asm2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
