using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WiktorDanielewskiLab5PracDom.Models
{
    /// <summary>
    /// Klasa reprezentująca część samochodu
    /// </summary>
    public class CarPart
    {
        public CarPart() { }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="producentID"></param>
        /// <param name="availability"></param>
        /// <param name="price"></param>
        public CarPart(int id, string name, int producentID, int availability, int price) {

            ID = id;
            Name = name;
            ProducentID = producentID;
            Availability = availability;
            Price = price;
        }



        [Key]
        [Display(Name = "ID")]
        /// <summary>
        /// Identyfikator częsci
        /// </summary>
        public int ID { get; set; }


        [Required]
        [MaxLength(50)]
        [Display(Name = "Nazwa")]
        /// <summary>
        /// Nazwa częsci
        /// </summary>
        public string Name { get; set; }


        [Required]
        [Display(Name = "Producent")]
        /// <summary>
        /// Identyfikator producenta
        /// </summary>
        public int ProducentID { get; set; }


        [Required]
        [Display(Name = "Dostępność")]
        /// <summary>
        /// Liczba dostępnych sztuk
        /// </summary>
        public int Availability { get; set; }


        [Required]
        [Display(Name = "Cena")]
        /// <summary>
        /// Pole zawierające cenę części
        /// </summary>
        public int Price { get; set; }






        //definiowanie klucza obcego
        [ForeignKey("ProducentID")]                 //definujemy jaka kolumna jest kluczem obcym
        public Producent Producent { get; set; }



        /// <summary>
        /// Umożliwi nam łatwiejszy dostęp do wszystkich opini, które dotyczą części o danym ID
        /// </summary>
        public ICollection<Opinion> Opinions { get; set; }

        /// <summary>
        /// Umożliwi nam łatwiejszy dostęp do wszystkich zamówień, które zawierają część o danym ID
        /// </summary>
        public ICollection<Order> Orders { get; set; }

    }
}
