using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WiktorDanielewskiLab6PracDom.Models
{
    public partial class Movies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public int YearOfRelease { get; set; }
        public int DirectorId { get; set; }

        [ForeignKey(nameof(DirectorId))]
        [InverseProperty(nameof(Directors.Movies))]
        public virtual Directors Director { get; set; }
    }
}
