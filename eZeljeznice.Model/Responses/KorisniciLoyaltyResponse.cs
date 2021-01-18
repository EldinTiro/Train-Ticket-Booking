using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model.Responses
{
    public class KorisniciLoyaltyResponse
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string Email { get; set; }
        public int BrojKupljenihKarata { get; set; }
        public int OstvareniPopust { get; set; }



    }
}
