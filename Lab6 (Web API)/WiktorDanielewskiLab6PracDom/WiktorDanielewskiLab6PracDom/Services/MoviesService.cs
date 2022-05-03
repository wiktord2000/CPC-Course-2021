using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab6PracDom.Models;

namespace WiktorDanielewskiLab6PracDom.Services
{
    public class MoviesService : IMoviesService
    {

        /// <summary>
        /// Dodanie kontekstu bazy danych
        /// </summary>
        private readonly DatabaseContext _context;

        public MoviesService()
        {
            _context = new DatabaseContext();
        }






        public List<Movies>Get()
        {
            return _context.Movies.ToList<Movies>();
        }


        public int Post(Movies movie)
        {

            // Sprawdzamy, czy reżyser o podanym id istnieje w bazie danych
            var director = _context.Directors.FirstOrDefault(m => m.Id.Equals(movie.DirectorId));

            // Jeśli reżyser o podanym id nie istnieje, jako indeks zostanie zwrócona wartośc -1
            if (director == null) return -1;
            // Przypisanie reżysera do filmu
            movie.Director = director;

            // Dodanie filmu do bazy danych
            _context.Movies.Add(movie);
            _context.SaveChanges();

            // Zwracamy indeks, który został przypisany filmowi
            return _context.Movies.Max(m => m.Id);

        }


        public int Put(int id, Movies movie)
        {
            // Sprawdzamy, czy pizza o podanym id w ogóle istnieje
            var movieToUpdate = _context.Movies.FirstOrDefault(m => m.Id.Equals(id));
            if (movieToUpdate == null) return -1;

            // Sprawdzamy, czy DirectorID jest poprawne
            var director = _context.Directors.FirstOrDefault(m => m.Id.Equals(movie.DirectorId));
            if (director == null) return -2;

            movieToUpdate.Title = movie.Title;
            movieToUpdate.YearOfRelease = movie.YearOfRelease;
            movieToUpdate.DirectorId = movie.DirectorId;

            // Aktualizacja bazy danych

            // Modyfikacja rekordu
            _context.Movies.Update(movieToUpdate);
            // Zapisanie zmian
            _context.SaveChanges();

            return 1;
        }


        public bool Delete(int id)
        {
            // Sprawdzamy, czy film o podamym id w ogóle istnieje
            var movieToDelete = _context.Movies.FirstOrDefault(m => m.Id.Equals(id));
            if (movieToDelete != null)
            {
                _context.Movies.Remove(movieToDelete);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
