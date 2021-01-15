using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model
{
    public class ObavjestenjeVM
    {
        public int ObavjestenjeId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime Datum { get; set; }
    }
}
