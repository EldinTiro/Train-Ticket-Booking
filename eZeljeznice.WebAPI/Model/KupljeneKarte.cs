using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class KupljeneKarte
    {
        [Key]
        [Column("ProdanaKartaID")]
        public int ProdanaKartaId { get; set; }
        [StringLength(10)]
        public string BrojRacuna { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DatumProdaje { get; set; }
        [Column("RezervacijaID")]
        public int? RezervacijaId { get; set; }
        public double? KonacnaCijena { get; set; }
        public int? Popust { get; set; }
        [Column("KupacID")]
        public int? KupacId { get; set; }

        [ForeignKey(nameof(KupacId))]
        [InverseProperty(nameof(Kupci.KupljeneKarte))]
        public virtual Kupci Kupac { get; set; }
        [ForeignKey(nameof(RezervacijaId))]
        [InverseProperty(nameof(Rezervacije.KupljeneKarte))]
        public virtual Rezervacije Rezervacija { get; set; }
    }
}
