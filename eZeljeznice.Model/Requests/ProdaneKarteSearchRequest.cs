using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class ProdaneKarteSearchRequest
    {
        public int PolaznaZeljeznickaStanica { get; set; }
        public int OdredisnaljeznickaStanica { get; set; }
        public DateTime DatumKarte { get; set; }
    }
}
