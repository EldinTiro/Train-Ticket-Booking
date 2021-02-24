using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class Kupci
    {
        public Kupci()
        {
            Pretrage = new HashSet<Pretrage>();
            Rezervacije = new HashSet<Rezervacije>();
            KupljeneKarte = new HashSet<KupljeneKarte>();
        }

        public int KupacId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Pretrage> Pretrage { get; set; }
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
        public virtual ICollection<KupljeneKarte> KupljeneKarte { get; set; }
        public virtual ICollection<RSII> RsII { get; set; }
    }
}
