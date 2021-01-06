using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class ProdaneKarteInsertRequest
    {
        public string BrojRacuna { get; set; }
        public DateTime? DatumProdaje { get; set; }
        public int? KupacId { get; set; }
        public int? RezervacijaId { get; set; }
        public double? KonacnaCijena { get; set; }
        public int? Popust { get; set; }
    }
}
