using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class Rezervacije
    {
        public Rezervacije()
        {
            KupljeneKarte = new HashSet<KupljeneKarte>();
        }

        public int RezervacijaId { get; set; }
        public int? KupacId { get; set; }
        public int? PutovanjeId { get; set; }
        public int? KartaId { get; set; }
        public DateTime? DatumRezervacije { get; set; }
        public bool? Kompletirana { get; set; }

        public virtual Karte Karta { get; set; }
        public virtual Kupci Kupac { get; set; }
        public virtual Putovanja Putovanje { get; set; }
        public virtual ICollection<Pretrage> Pretrage { get; set; }
        public virtual ICollection<KupljeneKarte> KupljeneKarte { get; set; }
    }
}
