using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class ZeljeznickeStanice
    {
        public ZeljeznickeStanice()
        {
            RelacijeZeljeznickaStanicaDo = new HashSet<Relacije>();
            RelacijeZeljeznickaStanicaOd = new HashSet<Relacije>();
        }

        public int ZeljeznickaStanicaId { get; set; }
        public string Naziv { get; set; }
        public int? GradId { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public virtual Gradovi Grad { get; set; }
        public virtual ICollection<Relacije> RelacijeZeljeznickaStanicaDo { get; set; }
        public virtual ICollection<Relacije> RelacijeZeljeznickaStanicaOd { get; set; }
    }
}
