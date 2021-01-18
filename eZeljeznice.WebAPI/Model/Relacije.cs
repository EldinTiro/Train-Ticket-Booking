using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Relacije
    {
        public Relacije()
        {
            Pretrage = new HashSet<Pretrage>();
            Putovanja = new HashSet<Putovanja>();
        }

        [Key]
        [Column("RelacijaID")]
        public int RelacijaId { get; set; }
        [Column("ZeljeznickaStanicaODID")]
        public int? ZeljeznickaStanicaOdid { get; set; }
        [Column("ZeljeznickaStanicaDOID")]
        public int? ZeljeznickaStanicaDoid { get; set; }

        [ForeignKey(nameof(ZeljeznickaStanicaDoid))]
        [InverseProperty(nameof(ZeljeznickeStanice.RelacijeZeljeznickaStanicaDo))]
        public virtual ZeljeznickeStanice ZeljeznickaStanicaDo { get; set; }
        [ForeignKey(nameof(ZeljeznickaStanicaOdid))]
        [InverseProperty(nameof(ZeljeznickeStanice.RelacijeZeljeznickaStanicaOd))]
        public virtual ZeljeznickeStanice ZeljeznickaStanicaOd { get; set; }
        [InverseProperty("Relacija")]
        public virtual ICollection<Pretrage> Pretrage { get; set; }
        [InverseProperty("Relacija")]
        public virtual ICollection<Putovanja> Putovanja { get; set; }
    }
}
