using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab5PracDom.Models;

namespace WiktorDanielewskiLab5PracDom.Controllers
{
    public class OpinionsController : Controller
    {
        // Dostęp do bazy danych
        private readonly DatabaseContext _context;


        public OpinionsController(DatabaseContext context) 
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Przekazanie do widoku tabeli z opiniami
            return View(_context.Opinions);
        }



    }
}
