using eZeljeznice.Model.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eZeljeznice.WinUI.Putovanja
{
    public partial class frmLoyalityProgram : Form
    {
        public frmLoyalityProgram()
        {
            InitializeComponent();
        }

        private readonly APIService _apiService = new APIService("korisnici");

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await _apiService.GetLoyality<List<KorisniciLoyaltyResponse>>();

            dgvLoyality.DataSource = result;

            dgvLoyality.Columns[0].Visible = false;
        }
    }
}
