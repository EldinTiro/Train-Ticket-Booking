using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model
{
    public class GradoviVM
    {
        public int? GradID { get; set; }
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? DatumObjave { get; set; }
    }
}
