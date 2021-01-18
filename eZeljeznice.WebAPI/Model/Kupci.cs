using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Kupci
    {
        public Kupci()
        {
            KupljeneKarte = new HashSet<KupljeneKarte>();
            Pretrage = new HashSet<Pretrage>();
            Rezervacije = new HashSet<Rezervacije>();
        }

        [Key]
        [Column("KupacID")]
        public int KupacId { get; set; }
        [StringLength(15)]
        public string KorisnickoIme { get; set; }
        [StringLength(150)]
        public string LozinkaSalt { get; set; }
        [StringLength(150)]
        public string LozinkaHash { get; set; }
        [StringLength(20)]
        public string Ime { get; set; }
        [StringLength(20)]
        public string Prezime { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DatumRegistracije { get; set; }
        [StringLength(100)]
        public string Email { get; set; }

        [InverseProperty("Kupac")]
        public virtual ICollection<KupljeneKarte> KupljeneKarte { get; set; }
        [InverseProperty("Kupac")]
        public virtual ICollection<Pretrage> Pretrage { get; set; }
        [InverseProperty("Kupac")]
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
