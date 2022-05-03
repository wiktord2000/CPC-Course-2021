using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab6PracDom.Models;

namespace WiktorDanielewskiLab6PracDom.Services
{
    public interface IDirectorsService
    {
        /// <summary>
        /// Metoda zwracająca wszystkich reżyserów
        /// </summary>
        /// <returns></returns>
        List<Directors> Get();

        /// <summary>
        /// Metoda dodająca nowego reżysera i zwracająca jego id
        /// </summary>
        /// <param name="director"></param>
        /// <returns></returns>
        int Post(Directors director);


        /// <summary>
        /// Metoda edytuje reżysera o wskazanym id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="director"></param>
        /// <returns></returns>
        int Put(int id, Directors director);

        /// <summary>
        /// Metoda zwracająca wszystkie filmy reżysera o danym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Movies> GetMovies(int directorId);
        
        /// <summary>
        /// Metoda usuwająca reżysera o wskazanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);
    }
}
