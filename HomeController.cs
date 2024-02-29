using Microsoft.AspNetCore.Mvc;
using zadanie1krok1.Models;
using System.Linq;


namespace zadanie1krok1.Controllers
    {
        public class TestController : Controller
        {
            private readonly MyAppDbContext _context;

        private TestController(MyAppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
            {
            var listaKlientow = new List<Klient>();

            var klienci = new List<Klient>();

            foreach (var klient in klienci)
            {
                listaKlientow.Add(new Klient
                {
                    Id = klient.Id,
                    name = klient.name,
                    surname = klient.surname,
                    Pesel = klient.Pesel,
                    BirthYear = klient.BirthYear,
                    Płeć = klient.Płeć
                });
            }


            return View(listaKlientow);
            }
        }
    }



