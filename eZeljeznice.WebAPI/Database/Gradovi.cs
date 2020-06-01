using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            Korisnici = new HashSet<Korisnici>();
            ZeljeznickeStanice = new HashSet<ZeljeznickeStanice>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Korisnici> Korisnici { get; set; }
        public virtual ICollection<ZeljeznickeStanice> ZeljeznickeStanice { get; set; }
    }
}
