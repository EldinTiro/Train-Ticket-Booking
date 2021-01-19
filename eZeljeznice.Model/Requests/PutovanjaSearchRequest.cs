using System;
using System.Collections.Generic;
using System.Text;

namespace eZeljeznice.Model.Requests
{
    public class PutovanjaSearchRequest
    {
        public string ZeljeznickaOdID { get; set; }
        public string ZeljeznickaDoID { get; set; }

        public DateTime VrijemePolaska { get; set; }

        public string WindowsIndikator { get; set; }

    }
}
