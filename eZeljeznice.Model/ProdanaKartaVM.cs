using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model
{
    public class ProdanaKartaVM
    {
        public string ImeKupca { get; set; }
        public string PrezimeKupca { get; set; }
        public string Relacija { get; set; }
        public string BrojRacuna { get; set; }
        public DateTime? DatumProdaje { get; set; }
        public int? Popust { get; set; }
        public double? KonacnaCijena { get; set; }
        public int? RezervacijaId { get; set; }
        public int? KorisnikId { get; set; }
        public int ProdanaKartaId { get; set; }


    }
}
