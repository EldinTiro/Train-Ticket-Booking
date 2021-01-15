using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eZeljeznice.WebAPI.Model
{
    public partial class Obavjestenja
    {
        [Key]
        [Column("ObavjestenjaID")]
        public int ObavjestenjaId { get; set; }
        [StringLength(500)]
        public string Sadrzaj { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Datum { get; set; }
    }
}
