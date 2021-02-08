using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model
{
    public class NekompletiraneRezervacijeResponse
    {
        public string ImePutovanja { get; set; }
        public DateTime? DatumPolaska { get; set; }
        public string VrijemePolaska { get; set; }
        public string VrijemeDolaska { get; set; }
        public double? KonacnaCijena { get; set; }
        public DateTime? DatumRezervacije { get; set; }
        public bool? Kompletirana { get; set; }
        public string ImePrezimeKupca { get; set; }
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public string BrojKarte { get; set; }
        public int RezervacijaID { get; set; }

    }
}
