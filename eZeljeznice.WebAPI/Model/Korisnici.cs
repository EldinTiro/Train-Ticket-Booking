using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Korisnici
    {
        [Key]
        [Column("KorisnikID")]
        public int KorisnikId { get; set; }
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
        public DateTime? DatumRodjenja { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [Column("GradID")]
        public int? GradId { get; set; }
        public bool? Status { get; set; }

        [ForeignKey(nameof(GradId))]
        [InverseProperty(nameof(Gradovi.Korisnici))]
        public virtual Gradovi Grad { get; set; }
    }
}
