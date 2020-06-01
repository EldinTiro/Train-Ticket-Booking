using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class Relacije
    {
        public Relacije()
        {
            Pretrage = new HashSet<Pretrage>();
            Putovanja = new HashSet<Putovanja>();
        }

        public int RelacijaId { get; set; }
        public int? ZeljeznickaStanicaOdid { get; set; }
        public int? ZeljeznickaStanicaDoid { get; set; }

        public virtual ZeljeznickeStanice ZeljeznickaStanicaDo { get; set; }
        public virtual ZeljeznickeStanice ZeljeznickaStanicaOd { get; set; }
        public virtual ICollection<Pretrage> Pretrage { get; set; }
        public virtual ICollection<Putovanja> Putovanja { get; set; }
    }
}
