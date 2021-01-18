using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class PutovanjaInsertRequest
    {
        public int? RelacijaId { get; set; }
        public int? ZeljeznickaStanicaODID { get; set; }
        public int? ZeljeznickaStanicaDOID { get; set; }
        [Required]
        public DateTime? DatumPolaska { get; set; }
        [Required]
        public DateTime? VrijemePolaska { get; set; }
        [Required]
        public DateTime? VrijemeDolaska { get; set; }
        [Required]
        [Range(0,double.MaxValue)]
        public double? Cijena { get; set; }
    }
}
