using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class Karte
    {
        public Karte()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int KartaId { get; set; }
        public int? RedniBrojVagona { get; set; }
        public int? RedniBrojSjedista { get; set; }

        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
