using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class KartaInsertRequest
    {
        public int KartaId { get; set; }
        public int? RedniBrojVagona { get; set; }
        public int? RedniBrojSjedista { get; set; }
    }
}
