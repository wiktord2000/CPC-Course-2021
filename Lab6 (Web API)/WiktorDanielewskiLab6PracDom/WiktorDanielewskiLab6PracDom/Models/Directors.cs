using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WiktorDanielewskiLab6PracDom.Models
{
    public partial class Directors
    {
        public Directors()
        {
            Movies = new HashSet<Movies>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [InverseProperty("Director")]
        public virtual ICollection<Movies> Movies { get; set; }
    }
}
