using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Karte
    {
        public Karte()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        [Key]
        [Column("KartaID")]
        public int KartaId { get; set; }
        public int? RedniBrojVagona { get; set; }
        public int? RedniBrojSjedista { get; set; }

        [InverseProperty("Karta")]
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
