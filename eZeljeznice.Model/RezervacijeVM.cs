using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model
{
    public class RezervacijeVM
    {
        public int RezervacijaId { get; set; }
        public int? KupacId { get; set; }
        public int? PutovanjeId { get; set; }
        public int? KartaId { get; set; }
        public DateTime? DatumRezervacije { get; set; }
        public DateTime? DatumPolaska { get; set; }
        public bool? Kompletirana { get; set; }
        public string ImePutovanja { get; set; }

        public string ImePrezimeKupca { get; set; }
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public string BrojKarte { get; set; }
        public string VrijemePolaska { get; set; }
        public string VrijemeDolaska { get; set; }
        public double? KonacnaCijena { get; set; }

    }
}
