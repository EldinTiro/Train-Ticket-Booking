using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class KupljeneKarte
    {
        public int ProdanaKartaId { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime? DatumProdaje { get; set; }
        public int? KorisnikId { get; set; }
        public int? RezervacijaId { get; set; }
        public double? KonacnaCijena { get; set; }
        public int? Popust { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Rezervacije Rezervacija { get; set; }
    }
}
