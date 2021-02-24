using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eZeljeznice.WebAPI.Database
{
    public class RSII
    {
        
        public virtual Kupci Kupac { get; set; }
        public int RSIIId { get; set; }
        public int KupacID { get; set; }
        public bool Maliciozan { get; set; }

    }
}
