using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab6PracDom.Models;

namespace WiktorDanielewskiLab6PracDom.Services
{
    public class DirectorsService : IDirectorsService
    {

        /// <summary>
        /// Dodanie kontekstu bazy danych
        /// </summary>
        private readonly DatabaseContext _context;

        public DirectorsService()
        {
            _context = new DatabaseContext();
        }









        public List<Directors> Get()
        {
            return _context.Directors.ToList<Directors>();
        }


        public int Post(Directors director)
        {
            // Dodanie reżysera do bazy danych
            _context.Directors.Add(director);
            _context.SaveChanges();

            // Zwracamy indeks, który został przypisany reżyserowi
            return _context.Directors.Max(m => m.Id);
        }




        public bool Delete(int id)
        {
            // Sprawdzamy, czy reżyser o podamym id w ogóle istnieje
            var directorToDelete = _context.Directors.FirstOrDefault(m => m.Id.Equals(id));
            if (directorToDelete != null)
            {
                _context.Directors.Remove(directorToDelete);
                _context.SaveChanges();
                return true;
            }
            return false;
        }





        public int Put(int id, Directors director)
        {
            // Sprawdzamy, czy reżyser o podanym id w ogóle istnieje
            var directorToUpdate = _context.Directors.FirstOrDefault(m => m.Id.Equals(id));
            if (directorToUpdate == null) return -1;

            directorToUpdate.FirstName = director.FirstName;
            directorToUpdate.LastName = director.LastName;

            // Modyfikacja rekordu 
            _context.Directors.Update(directorToUpdate);
            // Zapisanie zmian
            _context.SaveChanges();

            return 1;
        }

        public List<Movies> GetMovies(int directorId)
        {
            List<Movies> directorMovies = _context.Movies.Where(m => m.DirectorId == directorId).ToList<Movies>();

            if (directorMovies.Count == 0){
                return null;
            }

            return directorMovies;
        }
    }
}
