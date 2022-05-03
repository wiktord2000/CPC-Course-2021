using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WiktorDanielewskiLab5PracDom.Models
{
    /// <summary>
    /// Klasa reprezentująca zamówienie
    /// </summary>
    public class Order
    {



        public Order() { }

        public Order(int id, int carPartID, int number) 
        {
            ID = id;
            CarPartID = carPartID;
            Number = number;
        }


        [Key]
        /// <summary>
        /// Identyfikator zamówienia
        /// </summary>
        public int ID { get; set; }


        [Required]
        [Display(Name ="ID części")]
        /// <summary>
        /// Identyfikator części
        /// </summary>
        public int CarPartID { get; set; }


        [Required]
        [Display(Name ="Liczba")]
        /// <summary>
        /// Zamawiana liczba 
        /// </summary>
        public int Number { get; set; }


        //definiowanie klucza obcego
        [ForeignKey("CarPartID")]                 //definujemy jaka kolumna jest kluczem obcym
        public CarPart CarPart { get; set; }

    }
}
