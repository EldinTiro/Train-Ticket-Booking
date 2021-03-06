﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model
{
    public class KorisniciVM
    {
        public int KorisnikId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Email { get; set; }
        public bool? Status { get; set; }
    }
}
