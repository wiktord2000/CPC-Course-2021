using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiktorDanielewskiLab5PracDom.Models
{
    /// <summary>
    /// Tworzenie klasy mającej na celu reprezentowanie naszej bazy danych
    /// </summary>
    public class DatabaseContext : DbContext
    {
        //edytowanie w konstruktorze opcji bazy danych - dodanie connection string

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)      //base - wywołanie konstruktora klasy, po której dziedziczymy (DbContext)
        {
            // : base(options) odpowiada w C++ super(options)
        }

        //tworzenie tabel bazy danych

        /// <summary>
        /// Utworzenie tabeli CarParts
        /// </summary>
        public DbSet<CarPart> CarParts { get; set; }

        /// <summary>
        /// Utworzenie tabeli Opinions
        /// </summary>
        public DbSet<Opinion> Opinions { get; set; }

        /// <summary>
        /// Utworzenie tabeli Orders
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Utworzenie tabeli Producents
        /// </summary>
        public DbSet<Producent> Producents { get; set; }

    }
}
