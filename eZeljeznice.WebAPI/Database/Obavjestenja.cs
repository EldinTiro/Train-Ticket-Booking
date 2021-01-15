using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Database
{
    public class Obavjestenja
    {
        public int ObavjestenjaID { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime Datum { get; set; }
    }
}
