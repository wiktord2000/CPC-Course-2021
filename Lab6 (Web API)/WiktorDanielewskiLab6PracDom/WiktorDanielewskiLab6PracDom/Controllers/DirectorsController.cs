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
    public class DirectorsController : ControllerBase
    {

        //Dodanie serwisu
        private IDirectorsService _directorsService;

        public DirectorsController(IDirectorsService directorsService)
        {
            _directorsService = directorsService;
        }





        [HttpGet]
        [Produces(typeof(List<Directors>))]
        public IActionResult GetAllDirectors()
        {
            return Ok(_directorsService.Get());
        }


        [HttpGet]
        [Produces(typeof(List<Movies>))]
        [Route("{directorId}")]
        public IActionResult GetAllDirectorMovies([FromRoute] int directorId)
        {
            if (_directorsService.GetMovies(directorId) == null) return NotFound();
            return Ok(_directorsService.GetMovies(directorId));
        }





        [HttpPost]
        [Produces(typeof(int))]
        public IActionResult Post([FromBody] Directors director)
        {
            int id = _directorsService.Post(director);
            return Ok(id);
        }




        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Directors director)
        {

            int result = _directorsService.Put(id, director);

            if (result == -1)
            {
                return Conflict("Reżyser o podanym indeksie nie istnieje!");
            }

            return NoContent();
        }




        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            bool success = _directorsService.Delete(id);
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
