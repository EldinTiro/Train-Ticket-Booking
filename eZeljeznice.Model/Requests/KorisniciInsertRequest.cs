using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required]
        [MinLength(4)]
        public string KorisnickoIme { get; set; }
        [Required]
        [MinLength(4)]
        public string Ime { get; set; }
        [Required]
        [MinLength(4)]
        public string Prezime { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int GradID { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public int Status { get; set; }

    }
}
