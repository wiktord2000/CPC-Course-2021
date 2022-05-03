using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WiktorDanielewskiLab5PracDom.Models
{
    /// <summary>
    /// Klasa reprezentująca producenta
    /// </summary>
    public class Producent
    {

        public Producent() { }

        public Producent(int id, string name, string headOffice, int phoneNumber) 
        {
            ID = id;
            Name = name;
            HeadOffice = headOffice;
            PhoneNumber = phoneNumber;
        }


        [Key]
        /// <summary>
        /// Identyfikator producenta
        /// </summary>
        public int ID { get; set; }


        [Required]
        [MaxLength(50)]
        [Display(Name = "Producent")]
        /// <summary>
        /// Nazwa producenta
        /// </summary>
        public string Name { get; set; }


        [Required]
        [MaxLength(50)]
        [Display(Name = "Siedziba")]
        /// <summary>
        /// Siedziba producenta
        /// </summary>
        public string HeadOffice { get; set; }


        [Required]
        [Display(Name = "Numer telefonu")]
        /// <summary>
        /// Numer kontaktowy
        /// </summary>
        public int PhoneNumber { get; set; }




        /// <summary>
        /// Umożliwi nam łatwiejszy dostęp do wszystkich części, które należą do producenta o danym ID
        /// </summary>
        public ICollection<CarPart> CarParts { get; set; }

    }
}
