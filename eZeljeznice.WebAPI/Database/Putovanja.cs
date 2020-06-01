using System;
using System.Collections.Generic;

namespace eZeljeznice.WebAPI.Database
{
    public partial class Putovanja
    {
        public Putovanja()
        {
            Rezervacije = new HashSet<Rezervacije>();
        }

        public int PutovanjeId { get; set; }
        public int? RelacijaId { get; set; }
        public DateTime? DatumPolaska { get; set; }
        public TimeSpan? VrijemePolaska { get; set; }
        public TimeSpan? VrijemeDolaska { get; set; }
        public double? Cijena { get; set; }

        public virtual Relacije Relacija { get; set; }
        public virtual ICollection<Rezervacije> Rezervacije { get; set; }
    }
}
