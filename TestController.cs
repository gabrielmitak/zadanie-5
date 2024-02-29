using Microsoft.AspNetCore.Mvc;
using zadanie1krok1.Models;

namespace zadanie1krok1.Controllers
{
    public class TestController : Controller
    {
        private readonly MyAppDbContext _context;

        public TestController(MyAppDbContext context) => _context = context;

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Klient klient)
        {
            if (ModelState.IsValid)
            {
                _context.Klienci.Add(klient);
                object value = _context.SaveChanges();

                return RedirectToAction("Index", "Test");
            }
            return View(klient);
        }
    }
}
