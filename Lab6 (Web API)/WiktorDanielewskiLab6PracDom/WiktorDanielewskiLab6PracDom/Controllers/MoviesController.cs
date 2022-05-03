
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab6PracDom.Services;
using WiktorDanielewskiLab6PracDom.Models;

namespace WiktorDanielewskiLab6PracDom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase                 // Uwaga: bardzo ważne, aby dodać dziedziczenie po ControllerBase (m.in. zwracane kody będą działać)
    {

        //Dodanie serwisu
        private IMoviesService _moviesService;


        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }





        [HttpGet]
        [Produces(typeof(List<Movies>))]
        public IActionResult GetAllMovies()
        {
            return Ok(_moviesService.Get());
        }




        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Movies movie)
        {
            int id = _moviesService.Post(movie);
            if (id == -1) return Conflict("Podany reżyser nie istnieje");

            return Ok(id);
        }




        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Movies movie)
        {

            int result = _moviesService.Put(id , movie);

            if (result == -1)
            {
                return Conflict("Film o podanym indeksie nie istnieje!");
            }
            else if (result == -2)
            {
                return Conflict("Podany identyfikator reżysera nie istnieje!");
            }

            return NoContent();
        }




        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool success = _moviesService.Delete(id);
            if (success)
            {
                return NoContent();
            }
            else 
            {
                return NotFound();
            }
            
        }
    }
}
