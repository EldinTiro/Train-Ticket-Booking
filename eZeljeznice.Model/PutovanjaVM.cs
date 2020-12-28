using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model
{
    public class PutovanjaVM
    {
        public int PutovanjeID { get; set; }
        public int RelacijaID { get; set; }
        public string Polaziste { get; set; }
        public string Odrediste { get; set; }
        public DateTime? DatumPolaska { get; set; }
        public double? Cijena { get; set; }
        public string VrijemePolaska { get; set; }
        public string VrijemeDolaska { get; set; }
        public decimal ProsjecnaOcjena { get; set; }

    }
}
