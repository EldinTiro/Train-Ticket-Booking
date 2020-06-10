using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;

namespace eZeljeznice.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            var result = "https://localhost:44327/api/Korisnici".GetJsonAsync<dynamic>().Result();
        }
    }
}
