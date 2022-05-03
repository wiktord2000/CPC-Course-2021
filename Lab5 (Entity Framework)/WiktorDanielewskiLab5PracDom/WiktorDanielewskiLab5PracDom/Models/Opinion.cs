using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WiktorDanielewskiLab5PracDom.Models
{
    /// <summary>
    /// Klasa reprezentująca opinię
    /// </summary>
    public class Opinion
    {
        [Key]
        /// <summary>
        /// Identyfikator opinii
        /// </summary>
        public int ID { get; set; }


        [Required]
        [Display(Name = "ID części")]
        /// <summary>
        /// Identyfikator części samochodu
        /// </summary>
        public int CarPartID { get; set; }


        [Required]
        [MaxLength(50)]
        [Display(Name = "Podsumowanie")]
        /// <summary>
        /// Nagłówek opinii
        /// </summary>
        public string Header { get; set; }


        [Required]
        [MaxLength(200)]
        [Display(Name = "Opis")]
        /// <summary>
        /// Główny opis
        /// </summary>
        public string Description { get; set; }


        [Required]
        [Display(Name = "Ocena")]
        /// <summary>
        /// Ocena
        /// </summary>
        public int Rate { get; set; }



        //definiowanie klucza obcego
        [ForeignKey("CarPartID")]                 //definujemy jaka kolumna jest kluczem obcym
        public CarPart CarPart { get; set; }


    }
}
