using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model
{
    public class KupciVM
    {
        public int KupacId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaSalt { get; set; }
        public string LozinkaHash { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRegistracije { get; set; }
        public string Email { get; set; }
        public int BrojRezervacija { get; set; }
    }
}
