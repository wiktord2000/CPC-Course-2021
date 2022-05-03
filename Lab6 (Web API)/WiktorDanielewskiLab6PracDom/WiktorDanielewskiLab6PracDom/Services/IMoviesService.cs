using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WiktorDanielewskiLab6PracDom.Models;

namespace WiktorDanielewskiLab6PracDom.Services
{
    public interface IMoviesService
    {
        /// <summary>
        /// Metoda zwracająca wszystkie filmy
        /// </summary>
        /// <returns></returns>
        List<Movies> Get();

        /// <summary>
        /// Metoda dodająca nowy film i zwracająca jego id
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        int Post(Movies movie);


        /// <summary>
        /// Metoda edytuje film o wskazanym id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="movie"></param>
        /// <returns></returns>
        int Put(int id, Movies movie);


        /// <summary>
        /// Metoda usuwająca film o wskazanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(int id);

    }
}
