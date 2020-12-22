using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class PutovanjaAkcijaRequest
    {
        public int? ZeljeznickaStanicaODID { get; set; }
        public int? ZeljeznickaStanicaDOID { get; set; }
        [Required]
        public DateTime? AkcijaOD { get; set; }
        [Required]
        public DateTime? AkcijaDO { get; set; }
        public double VrijednostAkcije { get; set; }
    }
}
