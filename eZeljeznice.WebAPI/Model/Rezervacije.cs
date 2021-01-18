using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Rezervacije
    {
        public Rezervacije()
        {
            KupljeneKarte = new HashSet<KupljeneKarte>();
        }

        [Key]
        [Column("RezervacijaID")]
        public int RezervacijaId { get; set; }
        [Column("KupacID")]
        public int? KupacId { get; set; }
        [Column("PutovanjeID")]
        public int? PutovanjeId { get; set; }
        [Column("KartaID")]
        public int? KartaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatumRezervacije { get; set; }
        public bool? Kompletirana { get; set; }

        [ForeignKey(nameof(KartaId))]
        [InverseProperty(nameof(Karte.Rezervacije))]
        public virtual Karte Karta { get; set; }
        [ForeignKey(nameof(KupacId))]
        [InverseProperty(nameof(Kupci.Rezervacije))]
        public virtual Kupci Kupac { get; set; }
        [ForeignKey(nameof(PutovanjeId))]
        [InverseProperty(nameof(Putovanja.Rezervacije))]
        public virtual Putovanja Putovanje { get; set; }
        [InverseProperty("Rezervacija")]
        public virtual ICollection<KupljeneKarte> KupljeneKarte { get; set; }
    }
}
