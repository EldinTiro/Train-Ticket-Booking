using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            KupljeneKarte = new HashSet<KupljeneKarte>();
        }

        public int KorisnikId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Email { get; set; }
        public int? GradId { get; set; }
        public bool? Status { get; set; }

        public virtual Gradovi Grad { get; set; }
        public virtual ICollection<KupljeneKarte> KupljeneKarte { get; set; }
    }
}
