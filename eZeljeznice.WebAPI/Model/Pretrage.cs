using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Pretrage
    {
        [Key]
        [Column("PretragaID")]
        public int PretragaId { get; set; }
        [Column("RelacijaID")]
        public int? RelacijaId { get; set; }
        [Column("KupacID")]
        public int? KupacId { get; set; }
        public int? Ocjena { get; set; }

        [ForeignKey(nameof(KupacId))]
        [InverseProperty(nameof(Kupci.Pretrage))]
        public virtual Kupci Kupac { get; set; }
        [ForeignKey(nameof(RelacijaId))]
        [InverseProperty(nameof(Relacije.Pretrage))]
        public virtual Relacije Relacija { get; set; }
    }
}
