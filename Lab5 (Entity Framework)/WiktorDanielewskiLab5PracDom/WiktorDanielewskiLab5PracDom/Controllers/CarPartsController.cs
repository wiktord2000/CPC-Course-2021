using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab5PracDom.Models;

namespace WiktorDanielewskiLab5PracDom.Controllers
{
    public class CarPartsController : Controller
    {

        // Dostęp do bazy danych
        private readonly DatabaseContext _context;


        // Konstruktor
        public CarPartsController(DatabaseContext context) 
        {
            _context = context;
        }



        
        [HttpGet]
        public IActionResult Index()
        {
            // Dołączenie tabeli Producent. Jeśli przekażemy tablicę CarParts bez Include() to nie będziemy mogli korzystać z klucza obcego i odnosić się do tabeli Producent
            var table = _context.CarParts.Include(m => m.Producent);

            return View(table);
        }






        /// <summary>
        /// Przekierowanie do widoku Create
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create() {

            return View();
        }



        /// <summary>
        /// Odbieramy wczytane dane z formularza 
        /// </summary>
        /// <param name="carPartAndProducentViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(CarPart model)
        {



            Producent producent;
            producent = _context.Producents.FirstOrDefault(x => x.Name == model.Producent.Name);

            // Jeśli producent o danej nazwie istnieje w bazie danych to dodamy nową część
            if (producent != null)
            {

                _context.CarParts.Add(new CarPart(model.ID, model.Name, producent.ID, model.Availability, model.Price));
                _context.SaveChanges();
            }
            else {
                return View("MessageProducentNotExist");
            }

            //Powrót do widoku głównego kontrolera (Index)
            return RedirectToAction(nameof(Index));
        }





        /// <summary>
        /// Przekierowanie do widoku Delete
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Znalezienie obiektu o danym ID
            var carPart = _context.CarParts.Include(m => m.Producent).FirstOrDefault(m => m.ID.Equals(id));

            // Sprawdzamy, czy dany index istnieje w bazie
            if (carPart == null) {
                return NotFound();
            }

            // Wyświetlenie widoku
            return View(carPart);
        }

        /// <summary>
        /// Widok wyświetlający dane o wybranej do usunięcia części. Obiekt zostanie usunięty, gdy zostanie wciśnięty odpowiedni przycisk.
        /// </summary>
        /// <param name="carPart"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(CarPart carPart)
        {
            // Usunięcie opini o części
            var carPartOpinions = _context.Opinions.FirstOrDefault(m => m.CarPartID.Equals(carPart.ID));
            if (carPartOpinions != null)
            {
                _context.Opinions.RemoveRange(carPartOpinions);
                _context.SaveChanges();
            } 

            // Usunięcie zamówień danej części
            var carPartOrders = _context.Orders.FirstOrDefault(m => m.CarPartID.Equals(carPart.ID));
            if (carPartOrders != null) 
            {
                _context.Orders.RemoveRange(carPartOrders);
                _context.SaveChanges();
            }
            

            // Usunięcie części samochodowej z tabeli
            _context.CarParts.Remove(carPart);

            // Zapisanie zmian w bazie
            _context.SaveChanges();

            // Przekierowanie do widoku Index
            return RedirectToAction(nameof(Index));
        }






        /// <summary>
        /// Metoda odnajdująca cześć w tabeli CarParts na podstawie danego id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Modify(int id)
        {
            // Znalezienie obiektu o danym ID
            var carPart = _context.CarParts.Include(m => m.Producent).FirstOrDefault(m => m.ID.Equals(id));

            if (carPart == null)
            {
                return NotFound();
            }

            // Wyświetlenie widoku
            return View(carPart);
        }


        /// <summary>
        /// Metoda aktualizująca zawartość tablicy CarParts w bazie danych i przekierowująca do widoku Index
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Modify(CarPart carPart)
        {

            // Sprawdzenie, czy dany producent istnieje
            var producent = _context.Producents.FirstOrDefault(m => m.Name.Equals(carPart.Producent.Name));
            // Jeśli nie istnieje to zwracamy odpowiedni widok
            if (producent == null) 
            { 
                return View("MessageProducentNotExist");
            }

            // Uzupełniamy ProducentID (Mamy informację o jego nazwie, jednak nie mamy jego indeksu)
            carPart.ProducentID = producent.ID;

            // Wskazanie zmodyfikowanego rekordu
            _context.Entry(carPart).State = EntityState.Modified;

            // Modyfikacja rekordów o statusie Modified
            _context.CarParts.Update(carPart);

            // Zapisanie zmian
            _context.SaveChanges();

            // Przekierowanie do widoku Index
            return RedirectToAction(nameof(Index));
        }

    }
}
