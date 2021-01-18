using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class Pretrage
    {
        public int PretragaId { get; set; }
        public int? RelacijaId { get; set; }
        public int? KupacId { get; set; }
        public int? Ocjena { get; set; }
        public int? RezervacijaID { get; set; }
        public virtual Rezervacije Rezervacije { get; set; }
        public virtual Kupci Kupac { get; set; }
        public virtual Relacije Relacija { get; set; }
    }
}
