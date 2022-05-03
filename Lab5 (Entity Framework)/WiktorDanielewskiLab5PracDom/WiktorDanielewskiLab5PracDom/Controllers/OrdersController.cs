using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab5PracDom.Models;

namespace WiktorDanielewskiLab5PracDom.Controllers
{
    public class OrdersController : Controller
    {

        // Dostęp do bazy danych
        private readonly DatabaseContext _context;


        public OrdersController(DatabaseContext context) {
            _context = context;
        }



        /// <summary>
        /// Zwrócenie widoku Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(_context.Orders);
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
        /// Metoda dodająca nowe zamówienie
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(Order order)
        {
            // Sprawdzenie, czy część o podanym ID istnieje

            var carPart = _context.Orders.FirstOrDefault(m => m.ID.Equals(order.CarPartID));
            if (carPart == null) 
            {
                return View("MessageCarPartNotExist");            
            }

            // Dodanie do tablicy
            _context.Orders.Add(new Order(order.ID, order.CarPartID, order.Number));
            // Zapisanie
            _context.SaveChanges();

            // Przekierowanie do widoku głównego
            return RedirectToAction(nameof(Index));
        }
    }
}

