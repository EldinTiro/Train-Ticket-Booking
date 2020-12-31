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
        public bool? Kompletirana { get; set; }
    }
}
