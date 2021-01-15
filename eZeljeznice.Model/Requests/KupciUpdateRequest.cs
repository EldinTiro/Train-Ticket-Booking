using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class KupciUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
    }
}
