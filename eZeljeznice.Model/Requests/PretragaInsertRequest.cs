using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class PretragaInsertRequest
    {
        public int PretragaId { get; set; }
        public int? RelacijaId { get; set; }
        public int? KupacId { get; set; }
        public int? Ocjena { get; set; }
        public int? RezervacijaID { get; set; }
    }
}
