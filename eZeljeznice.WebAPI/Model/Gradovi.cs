using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            Korisnici = new HashSet<Korisnici>();
            ZeljeznickeStanice = new HashSet<ZeljeznickeStanice>();
        }

        [Key]
        [Column("GradID")]
        public int GradId { get; set; }
        [StringLength(30)]
        public string Naziv { get; set; }

        [InverseProperty("Grad")]
        public virtual ICollection<Korisnici> Korisnici { get; set; }
        [InverseProperty("Grad")]
        public virtual ICollection<ZeljeznickeStanice> ZeljeznickeStanice { get; set; }
    }
}
