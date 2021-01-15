using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Putovanja
    {
        public Putovanja()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        [Key]
        [Column("PutovanjeID")]
        public int PutovanjeId { get; set; }
        [Column("RelacijaID")]
        public int? RelacijaId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DatumPolaska { get; set; }
        public TimeSpan? VrijemePolaska { get; set; }
        public TimeSpan? VrijemeDolaska { get; set; }
        public double? Cijena { get; set; }

        [ForeignKey(nameof(RelacijaId))]
        [InverseProperty(nameof(Relacije.Putovanja))]
        public virtual Relacije Relacija { get; set; }
        [InverseProperty("Putovanje")]
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
