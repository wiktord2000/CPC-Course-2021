using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab5PracDom.Models;

namespace WiktorDanielewskiLab5PracDom.Controllers
{
    public class ProducentsController : Controller
    {

        // Dostęp do bazy danych
        private readonly DatabaseContext _context;


        public ProducentsController(DatabaseContext context) 
        {
            _context = context;
        }



        /// <summary>
        /// Zwrócenie widoku Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(_context.Producents);
        }








        /// <summary>
        /// Metoda zwracająca widok Create
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Metoda dodająca nowego producenta
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Producent producent)
        {
            // Dodanie do tablicy
            _context.Producents.Add(new Producent(producent.ID ,producent.Name, producent.HeadOffice, producent.PhoneNumber));
            // Zapisanie
            _context.SaveChanges();

            // Przekierowanie do widoku głównego
            return RedirectToAction(nameof(Index));
        }
    }
}
