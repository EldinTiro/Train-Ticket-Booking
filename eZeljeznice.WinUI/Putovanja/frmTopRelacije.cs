using eZeljeznice.Model.Requests;
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
    public partial class frmTopRelacije : Form
    {
        public frmTopRelacije()
        {
            InitializeComponent();
        }

        private readonly APIService _apiService = new APIService("putovanje");
        private readonly APIService _apiServiceZeljeznicke = new APIService("ZeljeznickeStanice");

        private async void btnPrikaziTop3Relacije_Click(object sender, EventArgs e)
        {
            var result = await _apiService.GetTopRelations<List<RelacijeTopSearchResponse>>();

            dgvTopRelacije.DataSource = result;
        }
    }
}
