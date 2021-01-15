using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class ObavjestenjeInsertRequest
    {
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }

        public DateTime? DatumObjave { get; set; }


    }
}
