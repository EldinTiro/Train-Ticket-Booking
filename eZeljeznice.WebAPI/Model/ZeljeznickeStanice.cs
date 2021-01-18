using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class ZeljeznickeStanice
    {
        public ZeljeznickeStanice()
        {
            RelacijeZeljeznickaStanicaDo = new HashSet<Relacije>();
            RelacijeZeljeznickaStanicaOd = new HashSet<Relacije>();
        }

        [Key]
        [Column("ZeljeznickaStanicaID")]
        public int ZeljeznickaStanicaId { get; set; }
        [StringLength(50)]
        public string Naziv { get; set; }
        [Column("GradID")]
        public int? GradId { get; set; }
        [StringLength(50)]
        public string Adresa { get; set; }
        [StringLength(15)]
        public string Telefon { get; set; }
        [StringLength(100)]
        public string Email { get; set; }

        [ForeignKey(nameof(GradId))]
        [InverseProperty(nameof(Gradovi.ZeljeznickeStanice))]
        public virtual Gradovi Grad { get; set; }
        [InverseProperty(nameof(Relacije.ZeljeznickaStanicaDo))]
        public virtual ICollection<Relacije> RelacijeZeljeznickaStanicaDo { get; set; }
        [InverseProperty(nameof(Relacije.ZeljeznickaStanicaOd))]
        public virtual ICollection<Relacije> RelacijeZeljeznickaStanicaOd { get; set; }
    }
}
